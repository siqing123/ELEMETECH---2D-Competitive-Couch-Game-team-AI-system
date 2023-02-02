using UnityEngine;

public class EarthSkills : MonoBehaviour
{
    // Earth Skills
    public GameObject EarthBoulder;
    public GameObject Points;
    private GameObject[] _pointsArr;
    public Vector3 LaunchOffset;
    private PlayerManager _playerManager;

    [SerializeField] int _numberOfPoints = 20;
    [SerializeField] float _spaceBetweenPoints = 0.01f;
    [SerializeField] private float _lanchForce = 10f;
    [SerializeField] private float _mass = 1f;
    [SerializeField] private float _damage = 10f;
    [SerializeField] private float _splashRange = 1.5f;
    [SerializeField] private float _knockBackAmount = 2f;
    private PlayerSkills _heroSkills;

    public float KnockBack { get => _knockBackAmount; }
    public float SplashRange { get => _splashRange; } 
    public float Damage { get => _damage; } 
    public float Mass { get => _mass; } 
    public float LaunchForce { get => _lanchForce; } 
    public PlayerSkills PlayerSkills { get => _heroSkills; } 


    private void Awake()
    {
        GameLoader.CallOnComplete(Initialize);
        _pointsArr = new GameObject[_numberOfPoints];
    }

    private void Initialize()
    {
        _playerManager = FindObjectOfType<PlayerManager>();
        _heroSkills = GetComponent<PlayerSkills>();
        _heroSkills.onEarthSkillPerformed += Boulder;

    }
    private void Boulder()
    {
        GameObject earthskill = Instantiate(EarthBoulder, 
            _playerManager.mPlayersList[3].GetComponent<HeroActions>().FirePoint.position, Quaternion.Euler(0, 0, _heroSkills.HeroAction.GetLookAngle));
        earthskill.tag = PlayerSkills.HeroMovement.tag;
    }

    private Vector2 PointPosition(float t)
    { 
        Vector2 position = (Vector2)_playerManager.mPlayersList[3].GetComponent<HeroActions>().FirePoint.position + 
            (_playerManager.mPlayersList[3].GetComponent<HeroActions>().GetLookDir * LaunchForce * t)
            + 0.5f * Physics2D.gravity * (t * t);
        return position;
    }
}