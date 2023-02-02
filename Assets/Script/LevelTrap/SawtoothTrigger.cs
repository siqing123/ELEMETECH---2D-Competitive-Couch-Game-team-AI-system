using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawtoothTrigger : MonoBehaviour
{
    [SerializeField] private SawtoothTrap mTrap = null;
    [SerializeField] private int mTriggerId = 0;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var heroStats = collision.gameObject.GetComponent<HeroStats>();
        if (heroStats)
        {
            mTrap.Move(mTriggerId);
        }
    }
}
