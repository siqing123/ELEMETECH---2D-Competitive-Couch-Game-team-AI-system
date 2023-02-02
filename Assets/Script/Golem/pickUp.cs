using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    private float lifeSpan = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == ("Team2"))
        {
            this.gameObject.SetActive(false);
        }
        else if(other.gameObject.tag == ("Team1"))
        {
            this.gameObject.SetActive(false);
        }
        else if(other.gameObject.tag == ("Enemy"))
        {

            //Destroy(this.gameObject);
            this.gameObject.SetActive(false);
            other.gameObject.GetComponent<Golem>().mCurrentHealth += 25.0f;       
        }
    }
}
