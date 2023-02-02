using UnityEngine;

public class WaterGun : MonoBehaviour
{
    private Rigidbody2D _RigidBody;
    private WaterSkills _WaterSkills;
    [SerializeField] private float _ProjectileSpeed;
    [SerializeField] private float _ExitTime = 2.0f;
    private bool _CanDamagePlayer = false;

    private void Awake()
    {
        _CanDamagePlayer = false;
        _RigidBody = GetComponent<Rigidbody2D>();
        _WaterSkills = FindObjectOfType<WaterSkills>();
        _ProjectileSpeed = _WaterSkills.Speed;
    }

    private void FixedUpdate()
    {
        if (_ExitTime <= 0.0f)
        {
            Destroy(gameObject);
        }
        _ExitTime -= Time.deltaTime;
        _RigidBody.velocity = transform.right * _WaterSkills.Speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>(), true);
        if (_CanDamagePlayer)
        {
            if (collision.collider.GetComponent<Golem>())
            {
                Golem golem = collision.gameObject.GetComponent<Golem>();
                if (golem != null)
                {
                    golem.TakeDamage(_WaterSkills.Damage);
                    Destroy(gameObject);
                }
            }

            if (collision.collider.GetComponent<Guard>())
            {
                if (collision.collider.GetComponent<Guard>().tag.Equals(_WaterSkills.PlayerSkills.HeroAction.tag))
                {
                    Guard guard = collision.collider.GetComponent<Guard>();
                    if (guard.Guarding)
                    {
                        Destroy(gameObject);
                        Debug.Log("Shield Hit");
                        collision.collider.GetComponent<Guard>().ComboSkillOn = true;
                    }
                }
            }

            if (_WaterSkills.PlayerSkills.HeroMovement.tag.Equals("Team1"))
            {
                if (collision.collider.tag.Equals("Team2"))
                {
                    if (collision.collider.TryGetComponent<HeroStats>(out HeroStats heroStats))
                    {
                        heroStats.TakeDamageFromProjectile(_WaterSkills.Damage);
                        Destroy(gameObject);

                    }
                    //collision.GetComponent<HeroStats>().DeBuff = StatusEffects.NegativeEffects.Slowed;
                    //collision.GetComponent<HeroStats>().SlowMovement(_WaterSkills.SlowAmount, _WaterSkills.SlowDuration);
                }
            }
            if (_WaterSkills.PlayerSkills.HeroMovement.tag.Equals("Team2"))
            {
                if (collision.collider.tag.Equals("Team1"))
                {
                    if (collision.collider.TryGetComponent<HeroStats>(out HeroStats heroStats))
                    {
                        heroStats.TakeDamageFromProjectile(_WaterSkills.Damage);
                        Destroy(gameObject);

                    }
                    //collision.GetComponent<HeroStats>().TakeDamage(_Damage);
                    //collision.GetComponent<HeroStats>().DeBuff = StatusEffects.NegativeEffects.Slowed;
                    //collision.GetComponent<HeroStats>().SlowMovement(_WaterSkills.SlowAmount, _WaterSkills.SlowDuration);
                }
            }

            if (collision.collider.GetComponentInParent<Walls>())
            {
                Destroy(gameObject);
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>(), false);
        _CanDamagePlayer = true;
    }

}
