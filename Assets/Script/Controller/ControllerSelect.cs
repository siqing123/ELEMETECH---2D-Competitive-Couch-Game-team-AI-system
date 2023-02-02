using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerSelect : MonoBehaviour
{
    public List<Button> ButtonList = new List<Button>();
    private List<int> _ControllerList = new List<int>();
    private PlayerManager _PlayerManager; 
    private static int _ControllerSelect1 = 0;
    private static int _ControllerSelect2 = 0;
    private static int _ControllerSelect3 = 0;
    private static int _ControllerSelect4 = 0;

    private void Awake()
    {
        GameLoader.CallOnComplete(Initialize);
    }

    private void Initialize()
    {
        _PlayerManager = ServiceLocator.Get<PlayerManager>();
    }

    void Start()
    {
        ButtonList[0].GetComponentInChildren<Text>().text = ((HeroMovement.Controller)_ControllerSelect1).ToString();
        ButtonList[1].GetComponentInChildren<Text>().text = ((HeroMovement.Controller)_ControllerSelect2).ToString();
        ButtonList[2].GetComponentInChildren<Text>().text = ((HeroMovement.Controller)_ControllerSelect3).ToString();
        ButtonList[3].GetComponentInChildren<Text>().text = ((HeroMovement.Controller)_ControllerSelect4).ToString();
    }

    public void SelectController1()
    {
        _ControllerSelect1++;
        if (_ControllerSelect1 > 5)
            _ControllerSelect1 = 0;

        switch (_ControllerSelect1)
        {
            case 0:
                ButtonList[0].GetComponentInChildren<Text>().text = "Controller None";
                _PlayerManager.FireHero.GetComponent<HeroMovement>().ControllerInput = (HeroMovement.Controller)_ControllerSelect1;
                break;
            case 1:
                ButtonList[0].GetComponentInChildren<Text>().text = "Keyboard";
                _PlayerManager.FireHero.GetComponent<HeroMovement>().ControllerInput =
               (HeroMovement.Controller)_ControllerSelect1;
                break;
            case 2:
                ButtonList[0].GetComponentInChildren<Text>().text = "PS4";
                _PlayerManager.FireHero.GetComponent<HeroMovement>().ControllerInput =
            (HeroMovement.Controller)_ControllerSelect1;
                break;
            case 3:
                ButtonList[0].GetComponentInChildren<Text>().text = "XBOX";
                _PlayerManager.FireHero.GetComponent<HeroMovement>().ControllerInput =
            (HeroMovement.Controller)_ControllerSelect1;
                break;
            case 4:
                ButtonList[0].GetComponentInChildren<Text>().text = "KeyboardLayout2";
                _PlayerManager.FireHero.GetComponent<HeroMovement>().ControllerInput =
            (HeroMovement.Controller)_ControllerSelect1;
                break;
            case 5:
                ButtonList[0].GetComponentInChildren<Text>().text = "GamePad";
                _PlayerManager.FireHero.GetComponent<HeroMovement>().ControllerInput =
            (HeroMovement.Controller)_ControllerSelect1;
                break;
            default:
                break;
        }

    }
    public void SelectController2()
    {
        _ControllerSelect2++;
        if (_ControllerSelect2 > 5)
            _ControllerSelect2 = 0;

        switch (_ControllerSelect2)
        {
            case 0:
                ButtonList[1].GetComponentInChildren<Text>().text = "Controller None";
                _PlayerManager.EarthHero.GetComponent<HeroMovement>().ControllerInput = (HeroMovement.Controller)_ControllerSelect2;
                break;
            case 1:
                ButtonList[1].GetComponentInChildren<Text>().text = "Keyboard";
                _PlayerManager.EarthHero.GetComponent<HeroMovement>().ControllerInput =
               (HeroMovement.Controller)_ControllerSelect2;
                break;
            case 2:
                ButtonList[1].GetComponentInChildren<Text>().text = "PS4";
                _PlayerManager.EarthHero.GetComponent<HeroMovement>().ControllerInput =
            (HeroMovement.Controller)_ControllerSelect2;
                break;
            case 3:
                ButtonList[1].GetComponentInChildren<Text>().text = "XBOX";
                _PlayerManager.EarthHero.GetComponent<HeroMovement>().ControllerInput =
            (HeroMovement.Controller)_ControllerSelect2;
                break;
            case 4:
                ButtonList[1].GetComponentInChildren<Text>().text = "KeyboardLayout2";
                _PlayerManager.EarthHero.GetComponent<HeroMovement>().ControllerInput =
            (HeroMovement.Controller)_ControllerSelect2;
                break;
            case 5:
                ButtonList[1].GetComponentInChildren<Text>().text = "GamePad";
                _PlayerManager.EarthHero.GetComponent<HeroMovement>().ControllerInput =
            (HeroMovement.Controller)_ControllerSelect2;
                break;
            default:
                break;
        }

    }
    public void SelectController3()
    {
        _ControllerSelect3++;
        if (_ControllerSelect3 > 5)
            _ControllerSelect3 = 0;

        switch (_ControllerSelect3)
        {
            case 0:
                ButtonList[2].GetComponentInChildren<Text>().text = "Controller None";
                _PlayerManager.WaterHero.GetComponent<HeroMovement>().ControllerInput = (HeroMovement.Controller)_ControllerSelect3;
                break;
            case 1:
                ButtonList[2].GetComponentInChildren<Text>().text = "Keyboard";
                _PlayerManager.WaterHero.GetComponent<HeroMovement>().ControllerInput =
               (HeroMovement.Controller)_ControllerSelect3;
                break;
            case 2:
                ButtonList[2].GetComponentInChildren<Text>().text = "PS4";
                _PlayerManager.WaterHero.GetComponent<HeroMovement>().ControllerInput =
            (HeroMovement.Controller)_ControllerSelect3;
                break;
            case 3:
                ButtonList[2].GetComponentInChildren<Text>().text = "XBOX";
                _PlayerManager.WaterHero.GetComponent<HeroMovement>().ControllerInput =
            (HeroMovement.Controller)_ControllerSelect3;
                break;
            case 4:
                ButtonList[2].GetComponentInChildren<Text>().text = "KeyboardLayout2";
                _PlayerManager.WaterHero.GetComponent<HeroMovement>().ControllerInput =
            (HeroMovement.Controller)_ControllerSelect3;
                break;
            case 5:
                ButtonList[2].GetComponentInChildren<Text>().text = "Gamepad";
                _PlayerManager.WaterHero.GetComponent<HeroMovement>().ControllerInput =
            (HeroMovement.Controller)_ControllerSelect3;
                break;
            default:
                break;
        }

    }
    public void SelectController4()
    {
        _ControllerSelect4++;
        if (_ControllerSelect4 > 5)
            _ControllerSelect4 = 0;

        switch (_ControllerSelect4)
        {
            case 0:
                ButtonList[3].GetComponentInChildren<Text>().text = "Controller None";
                _PlayerManager.AirHero.GetComponent<HeroMovement>().ControllerInput = (HeroMovement.Controller)_ControllerSelect4;
                break;
            case 1:
                ButtonList[3].GetComponentInChildren<Text>().text = "Keyboard";
                _PlayerManager.AirHero.GetComponent<HeroMovement>().ControllerInput =
               (HeroMovement.Controller)_ControllerSelect4;
                break;
            case 2:
                ButtonList[3].GetComponentInChildren<Text>().text = "PS4";
                _PlayerManager.AirHero.GetComponent<HeroMovement>().ControllerInput =
            (HeroMovement.Controller)_ControllerSelect4;
                break;
            case 3:
                ButtonList[3].GetComponentInChildren<Text>().text = "XBOX";
                _PlayerManager.AirHero.GetComponent<HeroMovement>().ControllerInput =
            (HeroMovement.Controller)_ControllerSelect4;
                break;
            case 4:
                ButtonList[3].GetComponentInChildren<Text>().text = "KeyboardLayout2";
                _PlayerManager.AirHero.GetComponent<HeroMovement>().ControllerInput =
            (HeroMovement.Controller)_ControllerSelect4;
                break;
            case 5:
                ButtonList[3].GetComponentInChildren<Text>().text = "GamePad";
                _PlayerManager.AirHero.GetComponent<HeroMovement>().ControllerInput =
            (HeroMovement.Controller)_ControllerSelect4;
                break;
            default:
                break;
        }
    }

}
