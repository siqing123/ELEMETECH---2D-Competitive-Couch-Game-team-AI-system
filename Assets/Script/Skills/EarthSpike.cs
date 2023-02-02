using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthSpike : MonoBehaviour
{
    private EarthSkills EarthSkills;
    private void Awake()
    {
        EarthSkills = FindObjectOfType<EarthSkills>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Golem>())
        {
            Golem golem = collision.GetComponent<Golem>();
            golem.TakeDamage(EarthSkills.Damage);
        }
        if (EarthSkills.PlayerSkills.HeroMovement.tag.Equals("Team1"))
        {
            if (collision.tag.Equals("Team2"))
            {
                if (collision.TryGetComponent<HeroStats>(out HeroStats heroStats))
                {
                    heroStats.TakeDamage(10f);
                }
                
            }
        }

        if (collision.GetComponent<Guard>())
        {
            if (collision.GetComponent<Guard>().tag.Equals(EarthSkills.PlayerSkills.HeroAction.tag))
            {
                Guard guard = collision.GetComponent<Guard>();
                if (guard.Guarding)
                {
                    Destroy(gameObject);
                    Debug.Log("Shield Hit");
                    collision.GetComponent<Guard>().ComboSkillOn = true;
                }
            }
        }
        if (EarthSkills.PlayerSkills.HeroMovement.tag.Equals("Team2"))
        {
            if (collision.tag.Equals("Team1"))
            {
                if (collision.TryGetComponent<HeroStats>(out HeroStats heroStats))
                {
                    heroStats.TakeDamage(10f);
                }
            }
        }
    }
}
