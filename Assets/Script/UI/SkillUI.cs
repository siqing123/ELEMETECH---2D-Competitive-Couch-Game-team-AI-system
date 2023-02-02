using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillUI : MonoBehaviour
{
    public Image cooldownImage;
    [SerializeField]
    private float mCoolDown = 2f;
    HeroActions mHeroActions;

    private void Awake()
    {
        mHeroActions = GetComponentInParent<HeroActions>();
    }

    private void Update()
    {
        if(mHeroActions.IsCooldown)
        {
            cooldownImage.fillAmount += 1 / mCoolDown * Time.deltaTime;
            if (cooldownImage.fillAmount >= 1)
            {
                cooldownImage.fillAmount = 0;
                mHeroActions.IsCooldown = false;
            }
        }
    }
}
