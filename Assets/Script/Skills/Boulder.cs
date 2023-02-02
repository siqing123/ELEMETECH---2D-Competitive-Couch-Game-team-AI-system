using UnityEngine;

public class Boulder : MonoBehaviour
{
    public GameObject ExplosionEffect;
    private Rigidbody2D _rigidBody;
    private EarthSkills _earthSkills;
    private bool _hasHit;
    private Vector3 _direction;
    private Vector3 _launchOffset;

    private void Awake()
    {
        _earthSkills = FindObjectOfType<EarthSkills>();
        _rigidBody = GetComponent<Rigidbody2D>();
        _launchOffset = _earthSkills.LaunchOffset;
        _rigidBody.mass = _earthSkills.Mass;
    }

    private void Start()
    {    
        _direction = transform.right + Vector3.up;
        _rigidBody.AddForce(_direction * _earthSkills.LaunchForce, ForceMode2D.Impulse);
    }

    private void FixedUpdate()
    {
        transform.position += transform.right * _earthSkills.LaunchForce * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponentInParent<Walls>())
        {
            Explode();
            Destroy(gameObject);
        }

        if (_earthSkills.SplashRange > 0)
        {
            var hitColliders = Physics2D.OverlapCircleAll(transform.position, _earthSkills.SplashRange);
            foreach (var hitCollider in hitColliders)
            {
                var enemyStats = hitCollider.GetComponent<HeroStats>();
                var enemyMovement = hitCollider.GetComponent<HeroMovement>();
                if (tag.Equals("Team1"))
                {
                    var closestPont = hitCollider.ClosestPoint(transform.position);
                    var distance = Vector3.Distance(closestPont, transform.position);
                    var damagePercent = Mathf.InverseLerp(_earthSkills.SplashRange, 0, distance);
                    if (enemyStats && enemyStats.tag.Equals("Team2"))
                    {
                        enemyStats.TakeDamageFromProjectile(damagePercent * (_earthSkills.Damage));
                        enemyMovement.OnKnockBackHit(_earthSkills.KnockBack, enemyMovement.GetIsLeft);
                    }
                    if (enemyStats && enemyStats.tag.Equals("Team1"))
                    {
                        //enemyStats.TakeDamageFromProjectile(damagePercent * (_earthSkills.Damage / 2f));
                        enemyMovement.OnKnockBackHit((_earthSkills.KnockBack / 2f), !enemyMovement.GetIsLeft);
                    }
                }
                if (tag.Equals("Team2"))
                {
                    var closestPont = hitCollider.ClosestPoint(transform.position);
                    var distance = Vector3.Distance(closestPont, transform.position);
                    var damagePercent = Mathf.InverseLerp(_earthSkills.SplashRange, 0, distance);
                    if (enemyStats && enemyStats.tag.Equals("Team1"))
                    {
                        enemyStats.TakeDamageFromProjectile(damagePercent * (_earthSkills.Damage));
                        enemyMovement.OnKnockBackHit(_earthSkills.KnockBack, !enemyMovement.GetIsLeft);
                    }
                    if (enemyStats && enemyStats.tag.Equals("Team2"))
                    {
                        //enemyStats.TakeDamageFromProjectile(damagePercent * (_earthSkills.Damage / 2f));
                        enemyMovement.OnKnockBackHit((_earthSkills.KnockBack / 2f), !enemyMovement.GetIsLeft);
                    }
                }
            }
        }

        if (gameObject.tag.Equals("Team1"))
        {
            if (collision.collider.tag.Equals("Team2"))
            {
                if (collision.gameObject.TryGetComponent<HeroStats>(out HeroStats heroStats))
                {
                    heroStats.TakeDamageFromProjectile(_earthSkills.Damage);
                    Explode();
                    Destroy(gameObject);
                }
            }
        }
        if (gameObject.tag.Equals("Team2"))
        {
            if (collision.collider.tag.Equals("Team1"))
            {
                if (collision.gameObject.TryGetComponent<HeroStats>(out HeroStats heroStats))
                {
                    heroStats.TakeDamageFromProjectile(_earthSkills.Damage);
                    Explode();
                    Destroy(gameObject);
                }
            }
        }
        if (_earthSkills.PlayerSkills.HeroMovement.tag.Equals("FFA"))
        {
            if (!collision.collider.Equals(this) && collision.collider.tag.Equals("FFA"))
            {
                if (collision.collider.TryGetComponent<HeroStats>(out HeroStats heroStats))
                {
                    heroStats.TakeDamageFromProjectile(_earthSkills.Damage);
                    Destroy(gameObject);
                }
            }
        }
    }

    private void Explode()
    {
        ParticleSystem ps = ExplosionEffect.GetComponent<ParticleSystem>();
        var sh = ps.shape;
        sh.radius = _earthSkills.SplashRange;
        Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
        ExplosionEffect.GetComponent<ParticleSystem>().Play();
    }
}
