using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirSkills : MonoBehaviour
{
    public GameObject mAirJet;

    [SerializeField]
    float mDamage = 2.0f;
    public float Damage { get { return mDamage; } }
    [SerializeField]
    float mSpeed = 10.0f;
    public float Speed { get { return mSpeed; } }
    [SerializeField]
    float mExitTime = 10.0f;
    public float ExitTime { get { return mExitTime; } }
    [SerializeField]
    Vector3 mScale;
    public Vector3 Scale { get { return mScale; } }
    [SerializeField]
    float mScaleSpeed; 
    public float ScaleSpeed { get { return mScaleSpeed; } }

    PlayerSkills mHeroSkills;
    public PlayerSkills PlayerSkills { get { return mHeroSkills; } }

    private void Start()
    {
        mHeroSkills = GetComponent<PlayerSkills>();
        mHeroSkills.onAirSkillPerformed += AirJet;
    }

    void AirJet()
    {
        Instantiate(mAirJet, mHeroSkills.HeroAction.FirePoint.transform.position, Quaternion.Euler(0, 0, mHeroSkills.HeroAction.GetLookAngle));
    }
}
