using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemBullet : MonoBehaviour
{
    [SerializeField]
    float damage  = 50.0f;
   // private Hero hero;
    private float lifeSpan = 5.0f;
    [SerializeField]
    float projectileSpeed = 5;
    private void Awake()
    {
        
        //hero = FindObjectOfType<Hero>();
        //if (hero.GetIsLeft)
        //{
        //    projectileSpeed = -projectileSpeed;
        //}

    }

    void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.tag == ("Wall"))
        {
            Destroy(gameObject);
        }
        
        if (other.gameObject.tag == "Team2")
        {
            Destroy(gameObject);
           other.GetComponent<HeroStats>().TakeDamage(damage);
        }

        if (other.gameObject.tag == "Team1")
        {
            Destroy(gameObject);
            other.GetComponent<HeroStats>().TakeDamage(damage);
        }
    }

    void Update()
    {
        if (lifeSpan > 0.0f)
        {
            lifeSpan -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
            lifeSpan = 5.0f;
        }
    }
}
