using System.Collections;
using UnityEngine;

public class HeroStats : MonoBehaviour
{
    public event System.Action<GameObject> onDebuffActivated;
    public event System.Action<GameObject> onDebuffDeActivated;

    private AnimationEvents _animationEvent;
    private Animator _animator;
    private Guard _guard;

    public enum TeamSetting
    {
        Team1,
        Team2,
        FFA
    };

    public TeamSetting Team = TeamSetting.FFA;

    // Basic Stats    
    [SerializeField] private float _meleeAttack = 10f;
    [SerializeField] private float _maxHealth = 100f;
    [SerializeField] private float _currentHealth = 100f;
    [SerializeField] private float _coolDown = 3f;
    private bool _isHealing = false;
    private float _tempCoolDownTime;
    private bool _isCoolDownFinished;

    // Getters & Setters 
    public bool CDFinished { get { return _isCoolDownFinished; } set { _isCoolDownFinished = value; } }
    public float CDTime { get { return _tempCoolDownTime; } set { _tempCoolDownTime = value; } }
    public float CoolDown { get { return _coolDown; } }
    public float CurrentHealth { get { return _currentHealth; } set { _currentHealth = value; } }
    public float MaxHealth { get { return _maxHealth; } }
    public float AttackDamage { get { return _meleeAttack; } }

    //Elemental Type
    [SerializeField] private Elements.ElementalAttribute _elementalType;
    public Elements.ElementalAttribute GetElement { get => _elementalType; } 

    //Buff & Debuff Effects
    [SerializeField] private StatusEffects.PositiveEffects _positiveEffect = StatusEffects.PositiveEffects.None;
    [SerializeField] private StatusEffects.NegativeEffects _negativeEffect = StatusEffects.NegativeEffects.None;
    public StatusEffects.PositiveEffects Buff { get => _positiveEffect;  set => _positiveEffect = value; } 
    public StatusEffects.NegativeEffects DeBuff { get => _negativeEffect;  set => _negativeEffect = value; }

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
        _animationEvent = GetComponentInChildren<AnimationEvents>();
        _currentHealth = _maxHealth;
        _tempCoolDownTime = 0;
        _guard = GetComponent<Guard>();
    }

    private void FixedUpdate()
    {
        if (_tempCoolDownTime <= 0.0f)
        {
            _tempCoolDownTime = 0.0f;
            _isCoolDownFinished = true;
        }
        if (_tempCoolDownTime > 0.0f)
        {
            _tempCoolDownTime -= Time.deltaTime;
        }

        if (_currentHealth <= 0)
        {
            HeroDie();
        }
    }

    public void TakeDamageFromProjectile(float damage)
    {
        if (!_animationEvent.DashProjectileInvincibility)
        {
            _isHealing = false;
            _currentHealth -= damage;
            switch (_negativeEffect)
            {
                case StatusEffects.NegativeEffects.OnFire:
                    onDebuffActivated?.Invoke(gameObject);
                    break;
                case StatusEffects.NegativeEffects.Slowed:
                    onDebuffActivated?.Invoke(gameObject);
                    break;
                case StatusEffects.NegativeEffects.Stunned:
                    break;
                case StatusEffects.NegativeEffects.None:
                    break;
                default:
                    break;
            }
        }
    }

    public void TakeDamage(float damage)
    {
        _isHealing = false;
        if (_currentHealth <= 0)
        {
            HeroDie();
        }
        if (_guard.Guarding)
        {
            _currentHealth -= (damage * 0.75f);
        }
        else
        {
            _currentHealth -= damage;
        }
     
        _animator.SetTrigger("HurtTrigger");
    }

    public void FallOutOfMap()
    {
        _currentHealth -= MaxHealth / 2f;
        if(_currentHealth <= 0)
        {
            HeroDie();
        }
        else
        {
            SpawnManager spawnManager = FindObjectOfType<SpawnManager>();            
            spawnManager.RespawnPlayer(gameObject);
        }
    }

    public void RestoreHealthOverTime(float duration, float amount, float maxAmount)
    {
        _isHealing = true;
        StartCoroutine(HealOverTimeCoroutine(duration, amount, maxAmount));
    }

    private IEnumerator HealOverTimeCoroutine(float duration, float amount, float maxAmount)
    {
        float amountHealed = 0;
            while (amountHealed <= maxAmount && _isHealing)
            {
                if (CurrentHealth >= MaxHealth)
                {
                    CurrentHealth = MaxHealth;
                    break;
                }
                amountHealed += amount;
                _currentHealth += amount;
                yield return new WaitForSeconds(duration);
            }
    }

    public void RestoreShield(float restoreAmount, float restoreTick)
    {
        StartCoroutine(RestoreShieldOverTimeCoroutine(restoreAmount, restoreTick));
    }

    private IEnumerator RestoreShieldOverTimeCoroutine(float restoreAmount, float restoreTick)
    {

        float restoreperloop = restoreAmount / restoreTick;
        while ((_guard.ShieldEnergy < _guard.ShieldMaxEnergy) && !_guard.Guarding)
        {
            _guard.ShieldEnergy += restoreperloop;
            yield return new WaitForSeconds(1f);
        }
        if (_guard.ShieldEnergy >= _guard.ShieldMaxEnergy)
        {
            _guard.IsShieldDisabled = false;
        }
    }

    public void DamageOverTime(float damageAmount, float damageDuration)
    {
        StartCoroutine(DamageOverTimeCoroutine(damageAmount, damageDuration));
    }

    private IEnumerator DamageOverTimeCoroutine(float damageAmount, float duration)
    {
        float amountDamaged = 0;
        float damagePerloop = damageAmount / duration;
        while (amountDamaged < damageAmount)
        {
            _currentHealth -= damagePerloop;
            if (_currentHealth <= 0)
            {
                HeroDie();
            }
            Debug.Log(_elementalType.ToString() + "Hero Current Health" + _currentHealth);
            amountDamaged += damagePerloop;
            yield return new WaitForSeconds(1f);
        }
        _negativeEffect = StatusEffects.NegativeEffects.None;
        onDebuffDeActivated?.Invoke(gameObject);
    }

    public void SlowMovement(float mSlowAmount, float mSlowDuration)
    {
        StartCoroutine(SlowEffectCoroutine(mSlowAmount, mSlowDuration));
    }

    private IEnumerator SlowEffectCoroutine(float slowAmount, float duration)
    {
        HeroMovement heromovement = GetComponent<HeroMovement>();
        float maxSpeed = heromovement.Speed;
        heromovement.Speed = slowAmount;
        float slowPerLoop = slowAmount / duration;
        while (heromovement.Speed < maxSpeed)
        {
            heromovement.Speed += slowPerLoop;
            Debug.Log(_elementalType.ToString() + "Hero Current Speed" + heromovement.Speed);
            yield return new WaitForSeconds(1f);
        }
        _negativeEffect = StatusEffects.NegativeEffects.None;
        onDebuffDeActivated?.Invoke(gameObject);
    }

    private void HeroDie()
    {
        PlayerManager playermanager = ServiceLocator.Get<PlayerManager>();
        if (playermanager.TeamOne.Contains(gameObject))
        {
            playermanager.TeamOne.Remove(gameObject);
        }
        if (playermanager.TeamTwo.Contains(gameObject))
        {
            playermanager.TeamTwo.Remove(gameObject);
        }
        this.gameObject.SetActive(false);
    }
}
