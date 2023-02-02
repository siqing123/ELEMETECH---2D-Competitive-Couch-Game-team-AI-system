using UnityEngine;

public class Pivot : MonoBehaviour
{
    private HeroActions _HeroActions;

    private void Awake()
    {
        _HeroActions = GetComponentInParent<HeroActions>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_HeroActions.HeroMovement.GetIsLeft)
        {
            Vector3 objectscale = transform.localScale;
            objectscale.x = -0.1f;
            transform.localScale = objectscale; 
        }
        else
        {
            Vector3 objectscale = transform.localScale;
            objectscale.x = 0.1f;
            transform.localScale = objectscale;
        }
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, _HeroActions.GetLookAngle);
        
    }
}
