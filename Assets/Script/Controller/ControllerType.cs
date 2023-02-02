using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerType : MonoBehaviour
{
    public enum Controller
    {
        None,
        Keyboard,
        PS4,
        XBOX
    }

    public Controller controllerInput;

}
