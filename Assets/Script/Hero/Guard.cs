using UnityEngine;

public class Guard : MonoBehaviour
{
    public GameObject Shield;
    private GameObject _shield;
    private HeroActions _heroAction;
    private HeroMovement _heroMovement;
    private bool _shieldCreated = false;
    private bool _skillCombine = false;
    private bool _shieldBreak = false;
    public bool IsShieldDisabled = false;

    private ParticleSystemManager _particleSystemManager;

    [SerializeField] private bool _isGuarding = false;
    [SerializeField] private float _guardTime = 0.5f;
    [SerializeField] private float _shieldSize = 2.1f;
    [SerializeField] private float _shieldRecoveryTick = 3f;
    [SerializeField] private float _speedDecrease = 1f;
    [SerializeField] private float _shieldMaxEnergy = 100f;
    [SerializeField] private float _shieldRecoverAmount = 1f;
    [SerializeField] private float _shieldEnergyTick = 0.2f;
    [SerializeField] private float _shieldEnergy = 100f;

    // Setters & Getters
    public bool Guarding { get { return _isGuarding; } }
    public float ShieldMaxEnergy { get { return _shieldMaxEnergy; } }
    public float ShieldEnergy { get { return _shieldEnergy; } set { _shieldEnergy = value; } }
    public float ShieldRecoveryAmount { get { return _shieldRecoverAmount; } }
    public float ShieldRecoveryTick { get { return _shieldRecoveryTick; } }
    public bool ComboSkillOn { get { return _skillCombine; } set { _skillCombine = value; } }


    public GameObject ComboSkill;

    private void Start()
    {
        _particleSystemManager = FindObjectOfType<ParticleSystemManager>();
        _shieldEnergy = _shieldMaxEnergy;
        _heroAction = GetComponentInParent<HeroActions>();
        _heroAction.onGuardPerformed += OnGuardPerformed;
        _heroAction.onGuardExit += OnGuardExit;
    }

    private void Update()
    {
        if (_isGuarding)
        {
            if (_shield == null)
            {
                Debug.Log("Cannot Create Shield, No Element Attached");
            }
            else
            {
                _shield.transform.position = Vector3.MoveTowards(_shield.transform.position, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y + 0.5f), 1.0f);
                if (_shieldEnergy > 0)
                {
                    _shieldEnergy -= Time.deltaTime / _shieldEnergyTick;
                }
                else
                {
                    IsShieldDisabled = true;
                    _shieldBreak = true;
                    OnGuardExit();
                }
                Color color = _shield.GetComponent<SpriteRenderer>().color;
                color.a = (_shieldEnergy * 0.01f);
                _shield.GetComponent<SpriteRenderer>().color = color;
            }
        }
        if(_isGuarding && ComboSkillOn)
        {
            if (GetComponent<HeroStats>().GetElement == Elements.ElementalAttribute.Water)
            {
                GameObject ComboSkillClone = Instantiate(ComboSkill, transform.position, Quaternion.identity);
                ComboSkillClone.tag = this.GetComponent<HeroStats>().tag;
            }
            if (GetComponent<HeroStats>().GetElement == Elements.ElementalAttribute.Earth)
            {
                GameObject ComboSkillClone = Instantiate(ComboSkill, transform);
                ComboSkillClone.tag = this.GetComponent<HeroStats>().tag;
            }
            if (GetComponent<HeroStats>().GetElement == Elements.ElementalAttribute.Fire)
            {
                GameObject ComboSkillClone = Instantiate(ComboSkill, transform);
                ComboSkillClone.tag = this.GetComponent<HeroStats>().tag;
            }
            if (GetComponent<HeroStats>().GetElement == Elements.ElementalAttribute.Air)
            {
                GameObject ComboSkillClone = Instantiate(ComboSkill, transform);
                ComboSkillClone.tag = this.GetComponent<HeroStats>().tag;
            }
            //Debug.Log(FindObjectOfType<Guard>().gameObject.transform.position);
            ComboSkillOn = false;
        }
    }

    private void OnGuardPerformed()
    {
        _isGuarding = true;
        SummonGuard();
    }

    private void OnGuardExit()
    {
        Destroy(_shield);
        if (_shieldBreak)
        {
            GameObject shieldBreak = Instantiate(_particleSystemManager.GetDebuffEffects[0]);
            shieldBreak.transform.position = this.transform.position;
            _shieldBreak = false;
            shieldBreak.GetComponent<ParticleSystem>().Play();
        }
        _isGuarding = false;
        _shieldCreated = false;
    }

    private void OnDestroy()
    {
        _heroAction.onGuardPerformed -= OnGuardPerformed; 
        _heroAction.onGuardExit -= OnGuardExit;
    }

    private void SummonGuard()
    {
        if (!_shieldCreated && !IsShieldDisabled)
        {
            _shield = Instantiate(Shield, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y + 0.5f), Quaternion.identity);
            _shield.transform.localScale = new Vector3(_shieldSize,_shieldSize,_shieldSize);
            Color color = _shield.GetComponent<SpriteRenderer>().color;
            color.a = (_shieldEnergy * 0.01f);
            _shield.GetComponent<SpriteRenderer>().color = color;
            _shieldCreated = true;
        }
    }    
}
