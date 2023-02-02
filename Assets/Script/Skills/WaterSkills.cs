using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSkills : MonoBehaviour
{
    public GameObject mWaterGun;

    [SerializeField]
    private float mSpeed = 10f;
    public float Speed { get { return mSpeed; } }
    [SerializeField]
    private float mDamage = 5f;
    public float Damage { get { return mDamage; } }
    [SerializeField]
    //After a certain duration of time destroy gameobject if it is active
    private float mExitTime;
    public float ExitTime { get { return mExitTime; } }
    PlayerSkills mHeroSkills;
    public PlayerSkills PlayerSkills { get { return mHeroSkills; } }

    [SerializeField]
    private float mSlowAmount = 1f;
    public float SlowAmount { get { return mSlowAmount; } }
    [SerializeField]
    private float mSlowDuration = 1f;
    public float SlowDuration { get { return mSlowAmount; } }


    private void Start()
    {
        mHeroSkills = GetComponent<PlayerSkills>();
        mHeroSkills.onWaterSkillPerformed += WaterGun;
    }

    void WaterGun()
    {
        Instantiate(mWaterGun, mHeroSkills.HeroAction.FirePoint.transform.position, Quaternion.Euler(0, 0, mHeroSkills.HeroAction.GetLookAngle));

    }

}
