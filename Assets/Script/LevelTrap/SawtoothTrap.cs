
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawtoothTrap : MonoBehaviour
{

    [SerializeField]
    private GameObject Saw;
    [SerializeField]
    private GameObject[] waypoints;
    private int current = 0;
    private float WPreadius = 1;
    [SerializeField]
    private float moveSpeed = 0;
    [SerializeField]
    private bool workWay = false;
    private bool isActive = false;
    int mTriggerId = 0;
    int count = 0;

    public void Move(int TriggerId)
    {
        if (!isActive)
        {
            isActive = true;
            mTriggerId = TriggerId;
        }
    }

    void Update()
    {
        if (!workWay)
        {
            if (Vector3.Distance(waypoints[current].transform.position, Saw.transform.position) < WPreadius)
            {
                current++;
                if (current >= waypoints.Length)
                {
                    current = 0;
                }
            }
            Saw.transform.position = Vector3.MoveTowards(Saw.transform.position, waypoints[current].transform.position, Time.deltaTime * moveSpeed);
        }
        else
        {
            if (isActive)
            {
                if (Saw.transform.position == waypoints[0].transform.position && count == 1)
                {
                    isActive = false;
                    count = 0;
                }

                if(Saw.transform.position == waypoints[mTriggerId].transform.position)
                {
                    count = 1;
                }

                if(count == 1)
                {
                    Saw.transform.position = Vector3.MoveTowards(Saw.transform.position, waypoints[0].transform.position, Time.deltaTime * moveSpeed);
                }
                else
                {
                    Saw.transform.position = Vector3.MoveTowards(Saw.transform.position, waypoints[mTriggerId].transform.position, Time.deltaTime * moveSpeed);
                }
            }
        }

    }
}
