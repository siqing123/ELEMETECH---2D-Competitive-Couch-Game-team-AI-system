using UnityEngine;

public class HealthOverTime : MonoBehaviour
{
    [SerializeField] private float _healthRecieved = 5f;
    [SerializeField] private float _maxmimumHealthRecieved = 20f;
    [SerializeField] private float _duratationOverTime = 0.5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<HeroStats>(out HeroStats heroStats))
        {
            heroStats.RestoreHealthOverTime(_duratationOverTime, _healthRecieved, _maxmimumHealthRecieved);
            Destroy(gameObject);
        }
    }
}
