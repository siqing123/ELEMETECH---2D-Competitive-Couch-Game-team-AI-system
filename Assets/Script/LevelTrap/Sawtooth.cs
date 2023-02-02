using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sawtooth : MonoBehaviour
{
    [SerializeField] private float mDamageTime = 1.0f;
    [SerializeField] private float mDamage = 5.0f;
    private const float mDelayTime = 1.0f;

    public struct TrappedHeroData
    {
        public HeroStats HeroStats;
        public DateTime EnterTime;
    }
    private List<TrappedHeroData> _trappedHeros = new List<TrappedHeroData>();

    private void Awake()
    {
        StartCoroutine(SawtoothDamageRoutine());
    }

    private IEnumerator SawtoothDamageRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(mDelayTime);
            if (_trappedHeros.Count > 0)
            {
                foreach (var trappedHero in _trappedHeros)
                {
                    trappedHero.HeroStats.TakeDamage(mDamage);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<HeroStats>())
        {
            TrappedHeroData data = new TrappedHeroData()
            {
                HeroStats = collision.GetComponent<HeroStats>(),
                EnterTime = DateTime.Now
            };
            _trappedHeros.Add(data);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<HeroStats>())
        {
            //TODO - remove hero from _trappedHeros list.
            TrappedHeroData data = new TrappedHeroData()
            {
                HeroStats = collision.GetComponent<HeroStats>(),
                EnterTime = DateTime.Now
            };

            for (int i = 0; i < _trappedHeros.Count; ++i)
            {
                if (_trappedHeros[i].HeroStats == data.HeroStats)
                {
                    _trappedHeros.Remove(_trappedHeros[i]);
                }
            }
        }
    }
}
