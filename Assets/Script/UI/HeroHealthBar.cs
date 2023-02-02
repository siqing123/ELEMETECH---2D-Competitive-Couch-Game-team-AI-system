using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroHealthBar : MonoBehaviour
{
    private HeroStats mHero;
    private Slider slider;

    void Awake()
    {
        mHero = GetComponentInParent<HeroStats>();
        slider = GetComponent<Slider>();
        slider.transform.position = 
            new Vector3(this.GetComponentInParent<HeroStats>().gameObject.transform.position.x,
                        this.GetComponentInParent<HeroStats>().gameObject.transform.position.y + 1.0f);
    }

    void Update()
    {
        float fillValue = mHero.CurrentHealth / mHero.MaxHealth;
        slider.value = fillValue;
    }
}
