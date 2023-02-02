using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    bool mSkillCombine = false;
    public bool ComboSkillOn { get { return mSkillCombine; } set { mSkillCombine = value; } }
    public GameObject CanonBall;



    private void Update()
    {
        if(ComboSkillOn)
        {
            Debug.Log("reached");
            Instantiate(CanonBall,FindObjectOfType<Guard>().gameObject.transform);
            Debug.Log(FindObjectOfType<Guard>().gameObject.transform.position);
            ComboSkillOn = false;

        }
    }
}
