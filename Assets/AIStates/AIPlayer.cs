using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class AIPlayer : MonoBehaviour
{
    [SerializeField] public Animator _aiController;
    public int nodeIndex;
    private Agent mAgent;
    private Transform target = null;
    private AIPlayerManager _manager = null;
    public float currentHP;
    public pickUp[] mkPickups;

    public HeroStats[] mHeros ;

    public HeroStats nearestHero;
    public HeroStats nearestHealth;
    public bool isMoving;

    private Golem golem;


    void Start()
    {
        isMoving = false;
        mAgent = GetComponent<Agent>();
        golem = this.GetComponent<Golem>();
        //nodeIndex = 0;//get number
        
        _manager = ServiceLocator.Get<AIPlayerManager>();
        _manager.AddAIPlayer(this);

        mHeros = GameObject.FindObjectsOfType<HeroStats>();
       
        mkPickups = GameObject.FindObjectsOfType<pickUp>();
    }

    // Update is called once per frame
    void Update()
    {
        currentHP = this.GetComponent<Golem>().mCurrentHealth;
        _aiController.SetFloat("HP", currentHP);

        //need track player position in both condition 
        IsPlayerNearby();
    }

    public void AttackMode()
    {
       // Debug.Log("hp > 40, attack the players");

        //find nearest hero and face to his positon.
        if (this.GetComponent<Transform>().position.x - mHeros[0].transform.position.x > 0)
        {
            this.GetComponent<Transform>().localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        }
        else
        {
            this.GetComponent<Transform>().localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }

        golem.Shoot();
        isMoving = false;
    }

    public void Run()
    {
       // Debug.Log("hp < 40, try to run away and looking for health");
    }

    public void setReturnTure()
    {
        _aiController.SetBool("return", true);
    }
    
    public void setReturnFalse()
    {
        _aiController.SetBool("return", false);
    }

    public void showHP()
    {
        Debug.Log(currentHP);
    }

    public void IsPlayerNearby()
    {
        foreach (var t in mHeros)
        {
            if(Mathf.Abs((t.GetComponent<HeroStats>().transform.position.x - this.GetComponent<Transform>().position.x)) < 5 
                && Mathf.Abs((t.GetComponent<HeroStats>().transform.position.y - this.GetComponent<Transform>().position.y)) < 5)
            {
                _aiController.SetBool("isPlayerNearby", true);
                nearestHero = t;
                return;
            }
        }
        _aiController.SetBool("isPlayerNearby", false);
    }
    public void IsPickUpNearby()
    {
        if (isMoving)
        {                     
           // Debug.Log("move to pickup nearby!");
        }
        else
        {
            foreach (var t in mkPickups)
            {
                if (t.isActiveAndEnabled && !isMoving)
                {
                   // Debug.Log("track any pickup nearby!");
                    mAgent.findPickup(t.gameObject.transform);
                    isMoving = true;
                }
            }
        }
            

        //find all the pickups and find which one is close to the player.
        // if(mkPickups[0] && (mkPickups[0].transform.position.x - this.transform.position.x) > 0)
        // {
        //     transform.localScale = new Vector3(1.0f,1.0f,1.0f);
        //     transform.Translate(new Vector2(this.GetComponent<Golem>().mSpeed, 0) * Time.deltaTime);
        // }
        // else if(mkPickups[0] && (mkPickups[0].transform.position.x - this.transform.position.x) < 0)
        // {
        //     transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        //     transform.Translate(new Vector2(-this.GetComponent<Golem>().mSpeed, 0) * Time.deltaTime);
        // }
        // else
        // {
        //     Debug.Log("cant find any pickup");
        // }
    }

    public void findHealth()
    {
        Debug.Log("Move to the health position");

        float step = this.GetComponent<Golem>().mSpeed * Time.deltaTime;
        gameObject.transform.localPosition = Vector3.MoveTowards(gameObject.transform.position, mkPickups[0].transform.position, step);
    }

    public void dashAway()
    {
        //Debug.Log("run away from players!");
        float dis = nearestHero.GetComponent<HeroStats>().transform.position.x - this.GetComponent<Transform>().position.x;
       
        if (dis < 5.0f && dis > 0.0f)
        {
            transform.Translate(new Vector2(-this.GetComponent<Golem>().mSpeed, 0) * Time.deltaTime);
        }   
        else if(dis < 0.0f && dis > -5.0f)
        {
            transform.Translate(new Vector2(this.GetComponent<Golem>().mSpeed, 0) * Time.deltaTime);
        }
    }
}
