using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBall : MonoBehaviour
{
    [SerializeField]
    private float mDamage = 50;
    private Vector3 targetPos;
    [SerializeField]
    private float targetXpos = 20f;
    private float targetYpos = 10f;

    [SerializeField]
    private float speed = 10;

    [SerializeField]
    private float mArcHeight = 1;

    private Vector3 nextPos;
    private Vector3 startPos;

    [SerializeField]
    private float SplashRange = 1;

    public GameObject explosionEffect;
    void Start()
    {
        // Cache our start position, which is really the only thing we need
        // (in addition to our current position, and the target).
        startPos = transform.position;
        if (GetComponentInParent<HeroMovement>().GetIsLeft)
        {
            targetPos = new Vector3(transform.position.x - targetXpos, transform.position.y + targetYpos);
        }
        else
        {
            targetPos = new Vector3(transform.position.x + targetXpos, transform.position.y + targetYpos);
        }
    }

    void Update()
    {
        // Compute the next position, with arc added in
        float x0 = startPos.x;
        float x1 = targetPos.x;
        float dist = x1 - x0;
        float nextX = Mathf.MoveTowards(transform.position.x, x1, speed * Time.deltaTime);
        float baseY = Mathf.Lerp(startPos.y, targetPos.y, (nextX - x0) / dist);
        float arc = mArcHeight * (nextX - x0) * (nextX - x1) / (-0.25f * dist * dist);
        nextPos = new Vector3(nextX, baseY + arc, transform.position.z);

        // Rotate to face the next position, and then move there
        transform.rotation = LookAt2D(nextPos - transform.position);
        transform.position = nextPos;

        // Do something when we reach the target
        if (nextPos == targetPos) Arrived();
    }

    void Arrived()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponentInParent<Walls>())
        {
            Debug.Log("wall hit");
            Explode();
           // OnDrawGizmosSelected();
            Destroy(gameObject);
        }
        if (SplashRange > 0)
        {
            var hitColliders = Physics2D.OverlapCircleAll(transform.position, SplashRange);
            foreach (var hitCollider in hitColliders)
            {
                var enemy = hitCollider.GetComponent<HeroStats>();
                if (tag.Equals("Team1"))
                {
                    if (enemy && enemy.tag.Equals("Team2"))
                    {
                        var closestPont = hitCollider.ClosestPoint(transform.position);
                        var distance = Vector3.Distance(closestPont, transform.position);

                        var damagePercent = Mathf.InverseLerp(SplashRange, 0, distance);
                        enemy.TakeDamage(damagePercent * mDamage);
                    }
                }
                else if (tag.Equals("Team2"))
                {
                    if (enemy && enemy.tag.Equals("Team1"))
                    {
                        var closestPont = hitCollider.ClosestPoint(transform.position);
                        var distance = Vector3.Distance(closestPont, transform.position);

                        var damagePercent = Mathf.InverseLerp(SplashRange, 0, distance);
                        enemy.TakeDamage(damagePercent * mDamage);
                    }
                }
            }
        }
        else
        {
            var enemy = collider.GetComponent<HeroStats>();
            if (tag.Equals("Team1"))
            {
                if (enemy.tag.Equals("Team2"))
                {
                    enemy.TakeDamage(mDamage);
                }
                Destroy(gameObject);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, SplashRange);
    }

    void Explode()
    {
        ParticleSystem ps = explosionEffect.GetComponent<ParticleSystem>();
        var sh = ps.shape;
        sh.radius = SplashRange;
        Instantiate(explosionEffect, transform.position, Quaternion.identity);        
        explosionEffect.GetComponent<ParticleSystem>().Play();
    }


static Quaternion LookAt2D(Vector2 forward)
    {
        return Quaternion.Euler(0, 0, Mathf.Atan2(forward.y, forward.x) * Mathf.Rad2Deg);
    }
}
