using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcyPlatform : MonoBehaviour
{
    float SlidSpeed = 5f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
            collision.gameObject.GetComponent<HeroMovement>().Speed += SlidSpeed;
        
    }
}
