using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random; 

public class IceTrapManager : MonoBehaviour
{
    public List<Transform> iceSpikesLocation = new List<Transform>();
    private List<Transform> spawnLocation = new List<Transform>();
    public List<Transform> SpawnLocation { get { return spawnLocation; } }
    public GameObject iceSpike;

    [SerializeField]
    float delayTime = 5.0f;
    float currentDelayTime = 0.0f;
    [SerializeField]
    int maxSpawnlocation = 3;
    [SerializeField]
    float damage = 50.0f;
    public float Damage { get { return damage; } }
    int iceSpikeCounter =0;

    public int IceSpikeCounter { set { iceSpikeCounter = value; } get { return iceSpikeCounter; } }
    private void Awake()
    {
        for (int i = 0; i < iceSpikesLocation.Count; i++)
        {
            spawnLocation.Add(iceSpikesLocation[i]);
        }
        for (int i = 0; i < maxSpawnlocation; ++i)
        {
            SpawnSpike();
        }
    }

    private void Update()
    {
        Debug.Log(spawnLocation.Count);
        if (iceSpikeCounter < maxSpawnlocation && currentDelayTime < Time.time)
        {
            currentDelayTime = Time.time + delayTime;
            SpawnSpike();
        }
    }

    public void SpawnSpike()
    {
        Transform location = spawnLocation[Random.Range(0, spawnLocation.Count)];
        Instantiate(iceSpike, location.position, Quaternion.identity);
        //for (int i = 0; i < spawnLocation.Count; ++i)
        //{
        //    if (spawnLocation[i].gameObject.transform.Equals(location))
        //    {
        //        spawnLocation[i].gameObject.SetActive(false);
        //    }
        //}
        spawnLocation.Remove(location);
        iceSpikeCounter++;
    }

    public void addNewLocation(Transform newLocation)
    {
        for (int i = 0; i < iceSpikesLocation.Count; i++)
        {
            if (iceSpikesLocation[i].transform.position == newLocation.position)
            {
                spawnLocation.Add(iceSpikesLocation[i]);
            }
        }
    }

}
