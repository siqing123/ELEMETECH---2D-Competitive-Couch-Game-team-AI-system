using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{
    private NavMeshAgent mAgent;
    [SerializeField] Transform mTarget;
    public bool isMoving;
    // Start is called before the first frame update
    void Start()
    {
        mAgent = GetComponent<NavMeshAgent>();
        mAgent.updateRotation = false;
        mAgent.updateUpAxis = false;
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void findPickup(Transform pickup)
    {
        mTarget = pickup;
        mAgent.SetDestination(mTarget.position);

        if (!isMoving)
        {
           
            isMoving = true;
        }
    }

}
