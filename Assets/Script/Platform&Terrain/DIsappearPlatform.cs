using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEngine;

public class DIsappearPlatform : MonoBehaviour
{
    public float disappearDelay = 2.0f;
    public float reappearDelay = 4.0f;
    public bool enabled = true;

    void Start()
    {
        enabled = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<HeroStats>() != null)
        {
            gameObject.SetActive(enabled);
            Invoke("Disappear", disappearDelay);
        }
    }
    //private void OnCollisionEnter(Collision other)
    //{

    //    if (other.gameObject.GetComponent<HeroStats>() != null)
    //    {
    //        gameObject.SetActive(false);

    //        //gameObject.SetActive(enabled);
    //        //Invoke("Disappear", disappearDelay);
    //    }
    //}

    private void Disappear()
    {
        //Code to make the platform disappear...
        
        gameObject.SetActive(false);

        Invoke("Reappear", reappearDelay);
    }

    private void Reappear()
    {
        //Make te platform appear again.
       
            gameObject.SetActive(true);
    }
}
    //void TogglePlatform()
    //{
    //    enabled = !enabled;

    //    //gameObject.SetActive(enabled);

    //    foreach (Transform child in gameObject.transform)
    //    {
    //        child.gameObject.SetActive(enabled);

    //    }
    //}


    //    void Update()
    //{
    //    currentTime += Time.deltaTime;
    //    if (currentTime >= timeToTogglePlatform)
    //    {
    //        currentTime = 0;
    //        TogglePlatform();
    //    }

       
            //foreach (Transform main in gameObject.transform)
            //{
            //    main.gameObject.SetActive(enabled);
            //}
    //    }
    //}


/*
 Making a disapearing platform.

1. When a collision happens, check if it is the player that is touching the platform.
2. If it is the player, then start a timer for the delay to disappear.
3. When the timer ends, then make the platform disappear.
4. Set timer for the delay to reappear.
5. When the timer ends, then make the platform reappear.

 */


