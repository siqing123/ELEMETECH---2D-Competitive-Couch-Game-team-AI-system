using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : MonoBehaviour
{
    private ItemManager itemManager;

    private void Awake()
    {
        itemManager = FindObjectOfType<ItemManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var heroStats = collision.GetComponent<HeroStats>();
        if (heroStats != null)
        {
            Debug.Log("hit player");
            if (heroStats.CurrentHealth + itemManager.HealthReply > heroStats.MaxHealth)
            {
                heroStats.CurrentHealth = heroStats.MaxHealth;
            }
            else
            {
                heroStats.TakeDamage(-itemManager.HealthReply);
            }
            

            // If it hits anything, destroy it.
            itemManager.SpawnIteam();
            itemManager.ItemCounter--;
            itemManager.addNewLocation(transform);
            Destroy(gameObject);
        }
    }
}
