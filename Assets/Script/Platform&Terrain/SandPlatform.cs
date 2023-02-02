using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandPlatform : MonoBehaviour
{
    float SandSpeed = 5f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<HeroMovement>().Speed -= SandSpeed;
    
    }

}
