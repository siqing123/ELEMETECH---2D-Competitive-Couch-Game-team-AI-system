using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sandstorm : MonoBehaviour
{
    private ParticleSystem mSteamParticle;
    [SerializeField]
    private float mSandstormDuration = 5f;
    [SerializeField]
    private float mDamage = 5f;
    [SerializeField]
    private float mDamageTick = 1f;
    private float totalTime = 0;
    [SerializeField]
    private float mProjectileSpeed;
    [SerializeField]
    private float mSlowAmount;
    private Rigidbody2D mRigidbody;
    private HeroMovement mHeroMovement;
    private bool isFiredLeft = false;

    private void Awake()
    {
        mSteamParticle = GetComponent<ParticleSystem>();
        mHeroMovement = GetComponentInParent<HeroMovement>();
        mRigidbody = GetComponent<Rigidbody2D>();
        if (mHeroMovement.GetIsLeft)
        {
            isFiredLeft = true;
        }
        
    }

    private void Start()
    {
  
        transform.parent = null;
        StartCoroutine(SandstormTimer());
        if(isFiredLeft)
        {
            mProjectileSpeed *= -1;
        }
    }

    IEnumerator SandstormTimer()
    {
        mSteamParticle.Play();
        yield return new WaitForSeconds(mSandstormDuration);
        Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
        mRigidbody.velocity = transform.right * mProjectileSpeed;
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
                    collision.GetComponent<HeroStats>().SlowMovement(mSlowAmount, 1f);
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
                    collision.GetComponent<HeroStats>().SlowMovement(mSlowAmount, 1f);
                    totalTime = 0;
                }
            }
        }
    }

}
