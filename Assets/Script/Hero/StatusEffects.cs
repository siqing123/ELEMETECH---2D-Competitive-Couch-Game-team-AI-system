using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusEffects : MonoBehaviour
{
  public enum PositiveEffects
    {
        AttackUp,
        DefenseUp,
        SpeedUp,
        None
    }

    public enum NegativeEffects
    {
        OnFire,
        Slowed, 
        Stunned,
        None
    }
}
