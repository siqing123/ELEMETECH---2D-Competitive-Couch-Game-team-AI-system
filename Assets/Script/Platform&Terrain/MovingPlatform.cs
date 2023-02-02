using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Player1)
        {
            Player1.transform.parent = transform;
        }
        if (other.gameObject == Player2)
        {
            Player2.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player1)
        {
            Player1.transform.parent = null ;
        }
        if (other.gameObject == Player2)
        {
            Player2.transform.parent = null;
        }
    }
}
