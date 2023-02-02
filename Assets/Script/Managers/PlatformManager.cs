using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> _switches = new List<GameObject>();
    [SerializeField] private List<GameObject> _elevatorList = new List<GameObject>();
    [SerializeField] private List<Transform> _platformOnePoints = new List<Transform>();
    [SerializeField] private List<Transform> _platformTwoPoints = new List<Transform>();
    [SerializeField] private float _timer = 3f;
    [SerializeField] private bool _isPlatformMoving = false;
    [SerializeField] private float _speed = 5f;

    public List<Transform> PlatformOnePoints { get => _platformOnePoints; }
    public List<Transform> PlatformTwoPoints { get => _platformTwoPoints; }
    private bool _isTimerOn = false;
    private ElevatorPlatform _platformOne;
    private ElevatorPlatform _platformTwo;
    public bool IsPlatformMovingDown { get => _isPlatformMoving; set => _isPlatformMoving = value; }
    public bool IsTimerOn { get => _isTimerOn; set => _isTimerOn = value; }
    public float PlatformSpeed { get => _speed; }


    private void Awake()
    {
        _platformOne = _elevatorList[0].GetComponent<ElevatorPlatform>();
        _platformTwo = _elevatorList[1].GetComponent<ElevatorPlatform>();

        for (int i = 0; i < _switches.Count; ++i)
        {
            _switches[i].GetComponent<Switch>().onSwitchActivated += OnSwitchActivated;
        }
    }

    private void Update()
    {
        if (IsTimerOn)
        {
            StartCoroutine(TimerCountDown());
        }        
    }

    private IEnumerator TimerCountDown()
    {
        yield return new WaitForSeconds(_timer);
        IsTimerOn = false;
    }

    private void ColorSwitch(bool toggle)
    {
        if (toggle)
        {
            for (int i = 0; i < _switches.Count; i++)
            {
                _switches[i].GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
        else
        {
            for (int i = 0; i < _switches.Count; i++)
            {
                _switches[i].GetComponent<SpriteRenderer>().color = Color.green;
            }
        }
    }

    private void OnSwitchActivated(int switchID)
    {
        if (!_isTimerOn)
        {
            for (int i = 0; i < _elevatorList.Count; i++)
            {
                if (switchID.Equals(i) && i.Equals(0))
                {
                    _platformOne = _elevatorList[switchID].GetComponent<ElevatorPlatform>();
                    if (!_platformTwo.Activated && !_platformOne.Activated &&
                       !_platformOne.PlatformMovingDown)
                    {
                        _platformOne.Activated = true;
                        _platformOne.PlatformMovingDown = true;
                        _platformOne.WayPointList = _platformOnePoints;
                    }
                    else if (!_platformTwo.Activated && !_platformOne.Activated &&
                        _platformOne.PlatformMovingDown)
                    {
                        _platformOne.Activated = true;
                        _platformOne.PlatformMovingDown = false;
                        _platformOne.WayPointList = _platformOnePoints;
                    }
                }
                if (switchID.Equals(i) && i.Equals(1))
                {
                    _platformTwo = _elevatorList[switchID].GetComponent<ElevatorPlatform>();
                    if (!_platformOne.Activated && !_platformTwo.Activated &&
                        !_platformTwo.PlatformMovingDown)
                    {
                        _platformTwo.Activated = true;
                        _platformTwo.PlatformMovingDown = true;
                        _platformTwo.WayPointList = _platformTwoPoints;
                    }
                    else if (!_platformOne.Activated && !_platformTwo.Activated
                        && _platformTwo.PlatformMovingDown)
                    {
                        _platformTwo.Activated = true;
                        _platformTwo.PlatformMovingDown = false;
                        _platformTwo.WayPointList = _platformTwoPoints;
                    }
                }
            }
        }
    }
}
