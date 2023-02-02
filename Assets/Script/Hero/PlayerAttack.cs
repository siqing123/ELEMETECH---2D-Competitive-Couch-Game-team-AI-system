using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private ParticleSystemManager _particleSystemManager;
    public event System.Action<GameObject> onAuraActivated;
    public event System.Action<GameObject> onAuraDeActivated;
    private HeroActions _heroAction;
    private HeroMovement _heroMovement;
        
    private bool swingActive = false;

    [SerializeField] private float _hitStun = 1f;
    [SerializeField] private float _rotationSpeed = 200f;
    [SerializeField] private float _rotationPerFrame = 20f;
    [SerializeField] private float _rotationgAngleLimit = 10f;
    [SerializeField] private float _originalRotation = 60f;
    [SerializeField] private float _knockBackAmount = 20f; 
    [SerializeField] private float _rotation = 0;
    private bool _originalDirLeft;

    private void Awake()
    {
        _particleSystemManager = FindObjectOfType<ParticleSystemManager>();
        _heroAction = GetComponentInParent<HeroActions>();
        _heroMovement = GetComponentInParent<HeroMovement>();
        _heroAction.onAttackPerformed += AttackPerformed;
    }
  
    private void AttackPerformed()
    {
        swingActive = true;
        if (_heroMovement.GetIsLeft)
        {
            _originalDirLeft = true;
             _rotation = 0;
            transform.eulerAngles = new Vector3(transform.position.x, transform.position.y, -_originalRotation);
        }
        else
        {
            _originalDirLeft = false;
            _rotation = 0;
            transform.eulerAngles = new Vector3(transform.position.x, transform.position.y, _originalRotation);
        }
    }

    private void Update()
    {
        if (swingActive)
        {            
            if (_heroMovement.GetIsLeft)
            {
                if(swingActive)
                {
                    SwordSwing(true);
                }
            }            
            else
            {
                if (swingActive)
                {
                    SwordSwing(false);
                }
            }
            if (_heroMovement.GetIsLeft == !_originalDirLeft)
            {
                _rotation = 0;
                _heroAction._isSwinging = false;
                gameObject.SetActive(false);
            }
        }
    }

    void SwordSwing(bool isLeft)
    {
        if (isLeft)
        {
            transform.RotateAround(transform.position, Vector3.forward, _rotationSpeed * Time.deltaTime);
            _rotation = _rotation + (Time.deltaTime * _rotationPerFrame);
            if (_rotation >= _rotationgAngleLimit)
            {
                _rotation = 0;
                transform.eulerAngles = new Vector3(transform.position.x, transform.position.y, -_originalRotation);
                _heroAction._isSwinging = false;
                swingActive = false;
                this.gameObject.SetActive(false);
            }
        }
        else
        {
            transform.RotateAround(transform.position, -Vector3.forward, _rotationSpeed * Time.deltaTime);
            _rotation = _rotation + (Time.deltaTime * _rotationPerFrame); 
            if (_rotation >= _rotationgAngleLimit)
            {
                _rotation = 0;
                transform.eulerAngles = new Vector3(transform.position.x, transform.position.y, _originalRotation);                
                _heroAction._isSwinging = false;
                swingActive = false;
                this.gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GetComponentInParent<HeroStats>().gameObject.tag.Equals("Team1"))
        {
            if (collision.tag.Equals("Team2"))
            {
                if (collision.TryGetComponent<HeroStats>(out HeroStats heroStats))
                {
                    heroStats.TakeDamage(_heroAction.HeroStats.AttackDamage);
                    collision.GetComponent<HeroMovement>().OnKnockBackHit(_knockBackAmount, GetComponentInParent<HeroMovement>().GetIsLeft);
                    if (_heroAction.HeroStats.GetElement.Equals(Elements.ElementalAttribute.Fire))
                    {
                        _particleSystemManager.FireAura(_heroMovement.gameObject);
                    }
                }
                if (!collision.GetComponent<Guard>().Guarding)
                {
                    collision.GetComponent<HeroMovement>().RecoveryTime = _hitStun;
                    collision.GetComponent<HeroMovement>().Recovering = true;
                }
            }
        }
        if (GetComponentInParent<HeroStats>().gameObject.tag.Equals("Team2"))
        {
            if (collision.tag.Equals("Team1"))
            {
                if (collision.TryGetComponent<HeroStats>(out HeroStats heroStats))
                {
                    heroStats.TakeDamage(_heroAction.HeroStats.AttackDamage);
                    collision.GetComponent<HeroMovement>().OnKnockBackHit(_knockBackAmount, GetComponentInParent<HeroMovement>().GetIsLeft);
                    if (_heroAction.HeroStats.GetElement == Elements.ElementalAttribute.Fire)
                    {
                        _particleSystemManager.FireAura(_heroMovement.gameObject);
                    }
                }                
                if (!collision.GetComponent<Guard>().Guarding)
                {
                    collision.GetComponent<HeroMovement>().RecoveryTime = _hitStun;
                    collision.GetComponent<HeroMovement>().Recovering = true;
                }
            }
        }

        if (collision.GetComponent<Golem>())
        {
            collision.GetComponent<Golem>().TakeDamage(_heroAction.HeroStats.AttackDamage);
        }
    }
}
