using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorPlatform : MonoBehaviour
{
    [SerializeField] private bool _isActive = false;
    [SerializeField] private bool _isPlatformMovingDown = false;
    [SerializeField] private List<Transform> _wayPointList = new List<Transform>();
    private PlatformManager _platformManager;

    public List<Transform> WayPointList { get => _wayPointList; set => _wayPointList = value; }
    public bool PlatformMovingDown { get => _isPlatformMovingDown; set => _isPlatformMovingDown = value; }
    public bool Activated { get => _isActive; set => _isActive = value; }

    private void Awake()
    {
        _platformManager = FindObjectOfType<PlatformManager>();
    }

    private void Update()
    {
        if (Activated)
        {
            if (_isPlatformMovingDown)
            {
                _platformManager.IsTimerOn = true;
                MoveDown();
            }
            else
            {
                _platformManager.IsTimerOn = true;
                MoveUp();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    public void MoveDown()
    {
        _platformManager.IsTimerOn = true;
        transform.position =
            Vector2.MoveTowards(transform.position,
            _wayPointList[1].position, _platformManager.PlatformSpeed * Time.deltaTime);
        if (transform.position.Equals(_wayPointList[1].position))
        {
            Activated = false;
        }
    }

    private void MoveUp()
    {        
        transform.position =
            Vector2.MoveTowards(transform.position,
            _wayPointList[0].position, _platformManager.PlatformSpeed * Time.deltaTime);
        if (transform.position.Equals(_wayPointList[0].position))
        {
            Activated = false;
        }
    }

    //private IEnumerator GoingBackUpCoroutine()
    //{
    //    yield return new WaitForSeconds(_platformManager.PlatformTimer);
    //    _isPlatformMovingDown = false;
    //}
}
