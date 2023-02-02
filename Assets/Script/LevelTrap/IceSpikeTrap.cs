using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpikeTrap : MonoBehaviour
{
    private IceTrapManager iceTrapManager;
    Vector3 startTransform = new Vector3();
    Rigidbody2D rb;
    

    private void Awake()
    {
        iceTrapManager = FindObjectOfType<IceTrapManager>();
        startTransform = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        var heroStats = collision.GetComponent<HeroStats>();
        if (heroStats != null)
        {
            Debug.Log("hit player");
            heroStats.TakeDamage(iceTrapManager.Damage);
            DestroySpike();
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("hit wall");
            DestroySpike();
        }
    }


    private void DestroySpike()
    {
        //transform.position = startTransform;
        //iceTrapManager.RandomNum.Add(transform);
        // If it hits anything, destroy it.
        iceTrapManager.SpawnSpike();
        iceTrapManager.IceSpikeCounter--;
        iceTrapManager.addNewLocation(GetComponentInParent<IceSpikeMovement>().transform);
        Destroy(GetComponentInParent<IceSpikeMovement>().gameObject); 
    }

    public void activeSpike()
    {
        rb.isKinematic = false;
    }
}
