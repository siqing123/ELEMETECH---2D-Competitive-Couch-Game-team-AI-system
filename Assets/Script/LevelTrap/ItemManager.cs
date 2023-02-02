using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ItemManager : MonoBehaviour
{
    public List<Transform> ItemLocation = new List<Transform>();
    private List<Transform> spawnLocation = new List<Transform>();
    public List<Transform> SpawnLocation { get { return spawnLocation; } }
    public GameObject Health;

    [SerializeField]
    private int maxSpawnlocation = 3;
    [SerializeField]
    private float health = 50.0f;
    public float HealthReply { get { return health; } }
    private int itemCounter = 0;

    public int ItemCounter { set { itemCounter = value; } get { return itemCounter; } }
    private void Awake()
    {
        for (int i = 0; i < ItemLocation.Count; i++)
        {
            spawnLocation.Add(ItemLocation[i]);
        }
        for (int i = 0; i < maxSpawnlocation; ++i)
        {
            SpawnIteam();
        }
    }

    private void Update()
    {
        Debug.Log(spawnLocation.Count);
        if (itemCounter < maxSpawnlocation)
        {
            SpawnIteam();
        }
    }

    public void SpawnIteam()
    {
        Transform location = spawnLocation[Random.Range(0, spawnLocation.Count)];
        Instantiate(Health, location.position, Quaternion.identity);
        spawnLocation.Remove(location);
        itemCounter++;
    }

    public void addNewLocation(Transform newLocation)
    {
        for (int i = 0; i < ItemLocation.Count; i++)
        {
            if (ItemLocation[i].transform.position == newLocation.position)
            {
                spawnLocation.Add(ItemLocation[i]);
            }
        }
    }
}
