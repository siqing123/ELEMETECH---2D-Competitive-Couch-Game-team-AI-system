using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkills : MonoBehaviour
{
    public event System.Action onEarthSkillPerformed;
    public event System.Action onFireSkillPerformed;
    public event System.Action onAirSkillPerformed;
    public event System.Action onWaterSkillPerformed;

    private HeroActions mHeroAction;
    public HeroActions HeroAction { get { return mHeroAction; } }
    private HeroMovement mHeroMovement;
    public HeroMovement HeroMovement { get { return mHeroMovement; } }
    private bool mIsSkillActivated = false;
    public bool SkillActive { get { return mIsSkillActivated; } set { mIsSkillActivated = value; } }
 
    private PlayerManager playerManager;

    private void Awake()
    {
        GameLoader.CallOnComplete(Initialize);
    }

    private void Initialize()
    {
        playerManager = FindObjectOfType<PlayerManager>();
    }

    private void Start()
    {
        if (playerManager.mPlayersList[0].gameObject != null)
        {
            playerManager.mPlayersList[0].GetComponent<HeroActions>().onSkillPerformed += PerformSkill;
        }
        if (playerManager.mPlayersList[1].gameObject != null)
        {
            playerManager.mPlayersList[1].GetComponentInChildren<HeroActions>().onSkillPerformed += PerformSkill;
        }
        if (playerManager.mPlayersList[2].gameObject != null)
        {
            playerManager.mPlayersList[2].GetComponent<HeroActions>().onSkillPerformed += PerformSkill;
        }
        if (playerManager.mPlayersList[3].gameObject != null)
        {
            playerManager.mPlayersList[3].GetComponent<HeroActions>().onSkillPerformed += PerformSkill;
        }
    }

    void PerformSkill(Elements.ElementalAttribute elementalAttribute)
    {
        switch (elementalAttribute)
        {
            case Elements.ElementalAttribute.Fire:
                mHeroAction = playerManager.mPlayersList[0].GetComponent<HeroActions>();
                mHeroMovement = playerManager.mPlayersList[0].GetComponent<HeroMovement>();
                onFireSkillPerformed.Invoke();
                break;
            case Elements.ElementalAttribute.Earth:
                mHeroAction = playerManager.mPlayersList[3].GetComponent<HeroActions>();
                mHeroMovement = playerManager.mPlayersList[3].GetComponent<HeroMovement>();
                onEarthSkillPerformed.Invoke();
                break;
            case Elements.ElementalAttribute.Water:
                mHeroAction = playerManager.mPlayersList[1].GetComponent<HeroActions>();
                mHeroMovement = playerManager.mPlayersList[1].GetComponent<HeroMovement>();
                onWaterSkillPerformed.Invoke();
                break;
            case Elements.ElementalAttribute.Air:
                mHeroAction = playerManager.mPlayersList[2].GetComponent<HeroActions>();
                mHeroMovement = playerManager.mPlayersList[2].GetComponent<HeroMovement>();
                onAirSkillPerformed.Invoke();
                break;
            default:
                break;
        }
    }

    private void OnDestroy()
    {
        if (playerManager.mPlayersList[0].gameObject != null)
        {
            playerManager.mPlayersList[0].GetComponent<HeroActions>().onSkillPerformed -= PerformSkill;
        }
        if (playerManager.mPlayersList[1].gameObject != null)
        {
            playerManager.mPlayersList[1].GetComponent<HeroActions>().onSkillPerformed -= PerformSkill;
        }
        if (playerManager.mPlayersList[2].gameObject != null)
        {
            playerManager.mPlayersList[2].GetComponent<HeroActions>().onSkillPerformed -= PerformSkill;
        }
        if (playerManager.mPlayersList[3].gameObject != null)
        {
            playerManager.mPlayersList[3].GetComponent<HeroActions>().onSkillPerformed -= PerformSkill;
        }

    }
}
