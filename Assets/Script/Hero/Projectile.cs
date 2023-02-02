using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    float damage = 2;
    [SerializeField]
    float projectileSpeed;
    private Rigidbody2D rigidbody;
    [SerializeField]
    float exitTime= 2.0f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = transform.right * projectileSpeed;
    }

    private void Update()
    {
        if (exitTime <= 0.0f)
        {
            Destroy(gameObject);
        }

        exitTime -= Time.deltaTime;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Golem>())
        {
            Debug.Log("Trigger");
            Golem golem = collision.gameObject.GetComponent<Golem>();
            if (golem != null)
            {
                golem.TakeDamage(damage);
                Destroy(gameObject);
            }
        }
    }
}
