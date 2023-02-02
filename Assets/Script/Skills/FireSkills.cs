using UnityEngine;

public class FireSkills : MonoBehaviour
{
    // FireSkills 
    public GameObject FireBallPrefab;
    private PlayerSkills _heroSkills;

    [SerializeField] private float _speed = 10.0f;
    [SerializeField] private float _damage = 10.0f;
    [SerializeField] private float _dotDuration = 5.0f;

    public float Speed { get => _speed;  set => _speed = value; } 
    public float Damage { get => _damage; } 
    public PlayerSkills PlayerSkills { get => _heroSkills; } 
    public float DotDuration { get => _dotDuration; } 

    private void Start()
    {
        _heroSkills = GetComponent<PlayerSkills>();
        _heroSkills.onFireSkillPerformed += FireBall;
    }

    void FireBall()
    {
       Instantiate(FireBallPrefab, _heroSkills.HeroAction.FirePoint.transform.position, Quaternion.Euler(0, 0, _heroSkills.HeroAction.GetLookAngle));
    }

}
