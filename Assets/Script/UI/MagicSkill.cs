using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicSkill : MonoBehaviour
{
    [Header("Skill")]
    [SerializeField]
    Image skillImageW;
    [SerializeField]
    Image skillImageA;
    [SerializeField]
    Image skillImageF;
    [SerializeField]
    Image skillImageE;
    HeroStats heroStats;

    private void Awake()
    {
        heroStats = FindObjectOfType<HeroStats>();
        skillImageW.fillAmount = 0;
        skillImageA.fillAmount = 0;
        skillImageF.fillAmount = 0;
        skillImageE.fillAmount = 0;
    }    

    private void Update()
    {

        //SkillF();
        //SkillE();
        //SkillW();
        //SkillA();
    }

    //void SkillW()
    //{
    //    if (heroW.GetComponent<Hero>().IsCDFinished)
    //    {
    //        skillImageW.fillAmount = 1;
    //    }
    //    if (!heroW.GetComponent<Hero>().IsCDFinished)
    //    {
    //        skillImageW.fillAmount -= 1 / heroW.GetComponent<Hero>().CoolDown * Time.deltaTime;
    //        if (skillImageW.fillAmount <= 0)
    //        {
    //            skillImageW.fillAmount = 0;
    //        }
    //    }
    //}

    //void SkillF()
    //{
    //    if (heroF.GetComponent<Hero>().IsCDFinished)
    //    {
    //        skillImageF.fillAmount = 1;
    //    }
    //    if (!heroF.GetComponent<Hero>().IsCDFinished)
    //    {
    //        skillImageF.fillAmount -= 1 / heroF.GetComponent<Hero>().CoolDown * Time.deltaTime;
    //        if (skillImageF.fillAmount <= 0)
    //        {
    //            skillImageF.fillAmount = 0;
    //        }
    //    }
    //}

    //void SkillE()
    //{
    //    if (heroE.GetComponent<Hero>().IsCDFinished)
    //    {
    //        skillImageE.fillAmount = 1;
    //    }
    //    if (!heroE.GetComponent<Hero>().IsCDFinished)
    //    {
    //        skillImageE.fillAmount -= 1 / heroE.GetComponent<Hero>().CoolDown * Time.deltaTime;
    //        if (skillImageE.fillAmount <= 0)
    //        {
    //            skillImageE.fillAmount = 0;
    //        }
    //    }
    //}

    //void SkillA()
    //{
    //    if (heroA.GetComponent<Hero>().IsCDFinished)
    //    {
    //        skillImageA.fillAmount = 1;
    //    }
    //    if (!heroA.GetComponent<Hero>().IsCDFinished)
    //    {
    //        skillImageA.fillAmount -= 1 / heroA.GetComponent<Hero>().CoolDown * Time.deltaTime;
    //        if (skillImageA.fillAmount <= 0)
    //        {
    //            skillImageA.fillAmount = 0;
    //        }
    //    }
    //}
}
