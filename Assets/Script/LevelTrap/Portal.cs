using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField]
    private Transform destination;
    private float distence = 0.3f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Vector2.Distance(transform.position, collision.transform.position) > distence)
        {
            collision.transform.position = new Vector3(destination.position.x, destination.position.y, destination.position.z);
            Debug.Log("move");
        }
    }
}
