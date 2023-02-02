using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golemManager : MonoBehaviour
{
    public static golemManager _instance;

    [SerializeField]
    private Transform[] spawnNodes;

    private int currentSpawnNodeIndex = 0;

    [SerializeField]
    private GameObject golemPrefab;
    private GameObject _golem;

    private int randNum;
    private List<int> SpawnNodeList = new List<int>();

    [SerializeField]
    private float timeLag = 5.0f;
    private float mTimeLag;
    void Awake()
    {
        _instance = this;
        mTimeLag = timeLag;
    }

    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        geneGolemByt();
    }

    public List<int> getSpawnNodeList()
    {
        return SpawnNodeList;
    }
    private bool UpdatePatrolNodeIndex()
    {    
        randNum = Random.Range(0,4);
        currentSpawnNodeIndex = (randNum) % spawnNodes.Length;
        if (!SpawnNodeList.Contains(currentSpawnNodeIndex))//!SpawnNodeIndex.Contains(currentSpawnNodeIndex)
        {
            SpawnNodeList.Add(currentSpawnNodeIndex);
            return true;
        }
        else
        {
            return false;
        }
    }

    private void geneGolem()
    {       
            if (UpdatePatrolNodeIndex())
            {             
                _golem = Instantiate(golemPrefab) as GameObject;               
                _golem.transform.position = spawnNodes[currentSpawnNodeIndex].position;
                _golem.GetComponent<Golem>().currentSpawnNodeIndex = currentSpawnNodeIndex;
                randGolemType();
                //_golem.GetComponent<Golem>().SetGolemType(GolemData.elementType.Water);
                return;
            }       
    }

    private void geneGolemByt()
    {
        if(SpawnNodeList.Count < spawnNodes.Length )
        {
            Debug.Log("in");
            if ( mTimeLag > 0.0f)
            {
                Debug.Log("in2");
                mTimeLag -= Time.deltaTime;               
            }
            else if(mTimeLag < 0.0f)
            {
                Debug.Log("in3");
                geneGolem();
                mTimeLag = timeLag;
            }

        }     
    }

    private void randGolemType()
    {
        if (randNum == 0)
        {
            _golem.GetComponent<Golem>().SetGolemType(GolemData.elementType.Water);
        }
        else if(randNum == 1)
        {
            _golem.GetComponent<Golem>().SetGolemType(GolemData.elementType.Fire);
        }
        else if(randNum == 2)
        {
            _golem.GetComponent<Golem>().SetGolemType(GolemData.elementType.Earth);
        }
        else if(randNum == 3)
        {
            _golem.GetComponent<Golem>().SetGolemType(GolemData.elementType.Air);
        }
    }
}
