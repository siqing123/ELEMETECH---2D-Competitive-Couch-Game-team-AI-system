using System.Collections;
using UnityEngine;

public class FireAura : MonoBehaviour
{
    [SerializeField] private float _damage = 5f;
    [SerializeField] private float _tick = 1f;
    private bool _tookDamage = false;
    public float SetDamage { set { _damage = value; } }
    public float SetTick { set => _tick = value; }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (tag.Equals("Team1"))
        {
            if (collision.tag.Equals("Team2"))
            {
                if(!_tookDamage)
                if (collision.TryGetComponent<HeroStats>(out HeroStats heroStats))
                {
                    StartCoroutine(DamageOverTimeCoroutine(heroStats,_damage));
                }
            }
        }

        if (tag.Equals("Team2"))
        {
            if (collision.tag.Equals("Team1"))
            {
                if (!_tookDamage)
                {
                    if (collision.TryGetComponent<HeroStats>(out HeroStats heroStats))
                    {
                        StartCoroutine(DamageOverTimeCoroutine(heroStats, _damage));
                    }
                }
            }
        }
    }

    private IEnumerator DamageOverTimeCoroutine(HeroStats hero, float damageAmount)
    {
        hero.TakeDamage(damageAmount);
        Debug.Log("Damaged Current Health: " + hero.CurrentHealth);
        _tookDamage = true;
        yield return new WaitForSeconds(_tick);
        _tookDamage = false;    
    }

}
