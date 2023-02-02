using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GolemHealthBar : MonoBehaviour
{
    private Golem mGolem;
    private Slider slider;

    void Awake()
    {
        mGolem = GetComponentInParent<Golem>();
        slider = GetComponent<Slider>();
        slider.transform.position = new Vector3
        ( this.GetComponentInParent<Golem>().gameObject.transform.position.x,
        this.GetComponentInParent<Golem>().gameObject.transform.position.y + 1.0f, 0f);
    }


    void Update()
    {
        float fillValue = mGolem.mCurrentHealth / mGolem.mMaxHealth;
        slider.value = fillValue;
    }
}
