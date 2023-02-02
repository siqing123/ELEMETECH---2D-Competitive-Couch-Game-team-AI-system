using UnityEngine;

public class Switch : MonoBehaviour
{
    public event System.Action<int> onSwitchActivated;
    [SerializeField] private int _switchID = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.GetComponent<PlayerAttack>())
        {
            onSwitchActivated?.Invoke(_switchID);
        }
    }
}
