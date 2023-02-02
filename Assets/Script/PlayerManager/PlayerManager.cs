using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Prefabs for Heros
    public GameObject FireHero;
    public GameObject WaterHero;
    public GameObject AirHero;
    public GameObject EarthHero;

    public List<GameObject> mPlayersList = new List<GameObject>();
    [SerializeField]
    private bool playTestMode = false;

    public List<GameObject> TeamOne = new List<GameObject>();
    public List<GameObject> TeamTwo = new List<GameObject>();

    private void Awake()
    {
        ServiceLocator.Register<PlayerManager>(this);
        FireHero.GetComponent<HeroMovement>().ControllerInput = HeroMovement.Controller.None;
        WaterHero.GetComponentInChildren<HeroMovement>().ControllerInput = HeroMovement.Controller.None;
        AirHero.GetComponent<HeroMovement>().ControllerInput = HeroMovement.Controller.None;
        EarthHero.GetComponent<HeroMovement>().ControllerInput = HeroMovement.Controller.None;

        mPlayersList[0] = FireHero;
        mPlayersList[1] = WaterHero;
        mPlayersList[2] = AirHero;
        mPlayersList[3] = EarthHero;

        TeamOne.Capacity = 0;
        TeamTwo.Capacity = 0;
    }

}
