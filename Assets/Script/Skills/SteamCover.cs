using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SteamCover : MonoBehaviour
{
    private ParticleSystem mSteamParticle;
    [SerializeField]
    private float mSteamDuration = 2f;
    [SerializeField]
    private float mDamage = 2f;
    [SerializeField]
    private float mDamageTick = 1f;
    private float totalTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        mSteamParticle = GetComponent<ParticleSystem>();
        StartCoroutine(SteamTimer());
    }
    
    IEnumerator SteamTimer()
    {
        mSteamParticle.Play();
        yield return new WaitForSeconds(mSteamDuration);
        Destroy(gameObject);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        totalTime += Time.deltaTime;
        if (tag.Equals("Team1"))
        {
            if (collision.tag.Equals("Team2"))
            {
                if (totalTime > mDamageTick)
                {
                    collision.GetComponent<HeroStats>().TakeDamage(mDamage);
                    totalTime = 0;
                }
            }
        }
        if (tag.Equals("Team2"))
        {
            if (collision.tag.Equals("Team1"))
            {
                if (totalTime > mDamageTick)
                {
                    collision.GetComponent<HeroStats>().TakeDamage(mDamage);
                    totalTime = 0;
                }
            }
        }
    }
}
