using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public GameObject _p1CrossHairs;
    public GameObject _p2CrossHairs;
    public GameObject _p3CrossHairs;
    public GameObject _p4CrossHairs;

    private Vector3 _p1Target;
    private Vector3 _p2Target;
    private Vector3 _p3Target;
    private Vector3 _p4Target;

    private HeroActions _fireHero = null;
    private HeroActions _waterHero = null;
    private HeroActions _airHero = null;
    private HeroActions _earthHero = null;

    private PlayerManager _playerManager;

    private void Awake()
    {
        GameLoader.CallOnComplete(Initialize);
    }

    private void Initialize()
    {
        _playerManager = FindObjectOfType<PlayerManager>();
        if (_playerManager.mPlayersList[0] != null)
        {
            _fireHero = _playerManager.mPlayersList[0].GetComponent<HeroActions>();
        }
        if (_playerManager.mPlayersList[1] != null)
        {
            _waterHero = _playerManager.mPlayersList[1].GetComponent<HeroActions>();
        }
        if (_playerManager.mPlayersList[2] != null)
        {
            _airHero = _playerManager.mPlayersList[2].GetComponent<HeroActions>();
        }
        if (_playerManager.mPlayersList[3] != null)
        {
            _earthHero = _playerManager.mPlayersList[3].GetComponent<HeroActions>();
        }
        if (_fireHero.gameObject.activeSelf)
        {
            _p1CrossHairs.SetActive(true);
        }
        if (_waterHero.gameObject.activeSelf)
        {
            _p2CrossHairs.SetActive(true);
        }
        if (_airHero.gameObject.activeSelf)
        {
            _p3CrossHairs.SetActive(true);
        }
        if (_earthHero.gameObject.activeSelf)
        {
            _p4CrossHairs.SetActive(true);
        }

        Cursor.visible = false;
    }


    void Update()
    {
        if (_fireHero.TryGetComponent<HeroMovement>(out HeroMovement fireMovement))
        {
            switch (fireMovement.ControllerInput)
            {
                case HeroMovement.Controller.None:
                    break;
                case HeroMovement.Controller.Keyboard:
                    _p1Target = transform.GetComponent<Camera>().ScreenToWorldPoint(_fireHero.PlayerInput.KeyboardMouse.Aim.ReadValue<Vector2>());
                    _p1CrossHairs.transform.position = new Vector3(_p1Target.x, _p1Target.y);
                    break;
                case HeroMovement.Controller.PS4:
                    _p1CrossHairs.transform.SetParent(_fireHero.transform);
                    if (_fireHero.PlayerInput.PS4.Aim.ReadValue<Vector2>().x.Equals(0f) &&
                        _fireHero.PlayerInput.PS4.Aim.ReadValue<Vector2>().y.Equals(0f))
                    {
                        _p1CrossHairs.SetActive(false);
                    }
                    else
                    {
                        _p1CrossHairs.SetActive(true);
                    }
                    _p1CrossHairs.transform.position = new Vector3(
                        _fireHero.transform.position.x + (_fireHero.PlayerInput.PS4.Aim.ReadValue<Vector2>().x * 5.5f),
                        _fireHero.transform.position.y + _fireHero.PlayerInput.PS4.Aim.ReadValue<Vector2>().y * 5.5f);
                    break;
                case HeroMovement.Controller.XBOX:
                    _p1CrossHairs.transform.SetParent(_fireHero.transform);
                    if (_fireHero.PlayerInput.XBOX.Aim.ReadValue<Vector2>().x.Equals(0f) &&
                        _fireHero.PlayerInput.XBOX.Aim.ReadValue<Vector2>().y.Equals(0f))
                    {
                        _p1CrossHairs.SetActive(false);
                    }
                    else
                    {
                        _p1CrossHairs.SetActive(true);
                    }
                    _p1CrossHairs.transform.position = new Vector3(
                        _fireHero.transform.position.x + (_fireHero.PlayerInput.XBOX.Aim.ReadValue<Vector2>().x * 5.5f),
                        _fireHero.transform.position.y + _fireHero.PlayerInput.XBOX.Aim.ReadValue<Vector2>().y * 5.5f);
                    break;
                case HeroMovement.Controller.Gamepad:
                    _p1CrossHairs.transform.SetParent(_fireHero.transform);
                    if (_fireHero.PlayerInput.Gamepad.Aim.ReadValue<Vector2>().x.Equals(0f) &&
                        _fireHero.PlayerInput.Gamepad.Aim.ReadValue<Vector2>().y.Equals(0f))
                    {
                        _p1CrossHairs.SetActive(false);
                    }
                    else
                    {
                        _p1CrossHairs.SetActive(true);
                    }
                    _p1CrossHairs.transform.position = new Vector3(
                        _fireHero.transform.position.x + (_fireHero.PlayerInput.Gamepad.Aim.ReadValue<Vector2>().x * 5.5f),
                        _fireHero.transform.position.y + _fireHero.PlayerInput.Gamepad.Aim.ReadValue<Vector2>().y * 5.5f);
                    break;
                default:
                    break;
            }
        }
        if (_waterHero.TryGetComponent<HeroMovement>(out HeroMovement waterMovement))
        {
            switch (waterMovement.ControllerInput)
            {
                case HeroMovement.Controller.None:
                    break;
                case HeroMovement.Controller.Keyboard:
                    _p2Target = transform.GetComponent<Camera>().ScreenToWorldPoint(_waterHero.PlayerInput.KeyboardMouse.Aim.ReadValue<Vector2>());
                    _p2CrossHairs.transform.position = new Vector3(_p2Target.x, _p2Target.y);
                    break;
                case HeroMovement.Controller.PS4:
                    _p2CrossHairs.transform.SetParent(_waterHero.transform);
                    if (_waterHero.PlayerInput.PS4.Aim.ReadValue<Vector2>().x.Equals(0f) &&
                        _waterHero.PlayerInput.PS4.Aim.ReadValue<Vector2>().y.Equals(0f))
                    {
                        _p2CrossHairs.SetActive(false);
                    }
                    else
                    {
                        _p2CrossHairs.SetActive(true);
                    }
                    _p2CrossHairs.transform.position = new Vector3(
                                      _waterHero.transform.position.x + (_waterHero.PlayerInput.PS4.Aim.ReadValue<Vector2>().x * 5.5f),
                                      _waterHero.transform.position.y + _waterHero.PlayerInput.PS4.Aim.ReadValue<Vector2>().y * 5.5f);
                    break;
                case HeroMovement.Controller.XBOX:
                    _p2CrossHairs.transform.SetParent(_waterHero.transform);
                    if (_waterHero.PlayerInput.XBOX.Aim.ReadValue<Vector2>().x.Equals(0f) &&
                        _waterHero.PlayerInput.XBOX.Aim.ReadValue<Vector2>().y.Equals(0f))
                    {
                        _p2CrossHairs.SetActive(false);
                    }
                    else
                    {
                        _p2CrossHairs.SetActive(true);
                    }
                    _p2CrossHairs.transform.position = new Vector3(
                                      _waterHero.transform.position.x + (_playerManager.mPlayersList[1].GetComponent<HeroActions>().PlayerInput.XBOX.Aim.ReadValue<Vector2>().x * 5.5f),
                                      _waterHero.transform.position.y + _playerManager.mPlayersList[1].GetComponent<HeroActions>().PlayerInput.XBOX.Aim.ReadValue<Vector2>().y * 5.5f);
                    break;
                case HeroMovement.Controller.Gamepad:
                    _p2CrossHairs.transform.SetParent(_waterHero.transform);
                    if (_waterHero.GetComponent<HeroActions>().PlayerInput.Gamepad.Aim.ReadValue<Vector2>().x.Equals(0f) &&
                        _waterHero.GetComponent<HeroActions>().PlayerInput.Gamepad.Aim.ReadValue<Vector2>().y.Equals(0f))
                    {
                        _p2CrossHairs.SetActive(false);
                    }
                    else
                    {
                        _p2CrossHairs.SetActive(true);
                    }
                    _p2CrossHairs.transform.position = new Vector3(
                                      _waterHero.transform.position.x + (_waterHero.GetComponent<HeroActions>().PlayerInput.Gamepad.Aim.ReadValue<Vector2>().x * 5.5f),
                                      _waterHero.transform.position.y + _waterHero.GetComponent<HeroActions>().PlayerInput.Gamepad.Aim.ReadValue<Vector2>().y * 5.5f);
                    break;
                default:
                    break;
            }
        }
        if (_airHero.TryGetComponent<HeroMovement>(out HeroMovement airMovement))
        {
            switch (airMovement.ControllerInput)
            {
                case HeroMovement.Controller.None:
                    break;
                case HeroMovement.Controller.Keyboard:
                    _p3Target = transform.GetComponent<Camera>().ScreenToWorldPoint(_airHero.HeroMovement.PlayerInput.KeyboardMouse.Aim.ReadValue<Vector2>());
                    _p3CrossHairs.transform.position = new Vector3(_p3Target.x, _p3Target.y);
                    break;
                case HeroMovement.Controller.PS4:
                    _p3CrossHairs.transform.SetParent(_airHero.transform);
                    if (_airHero.PlayerInput.PS4.Aim.ReadValue<Vector2>().x.Equals(0f) &&
                        _airHero.PlayerInput.PS4.Aim.ReadValue<Vector2>().y.Equals(0f))
                    {
                        _p3CrossHairs.SetActive(false);
                    }
                    else
                    {
                        _p3CrossHairs.SetActive(true);
                    }
                    _p3CrossHairs.transform.position = new Vector3(
                                      _airHero.transform.position.x + (_airHero.PlayerInput.PS4.Aim.ReadValue<Vector2>().x * 5.5f),
                                      _airHero.transform.position.y + _airHero.PlayerInput.PS4.Aim.ReadValue<Vector2>().y * 5.5f);
                    break;
                case HeroMovement.Controller.XBOX:
                    _p3CrossHairs.transform.SetParent(_airHero.transform);
                    if (_airHero.PlayerInput.XBOX.Aim.ReadValue<Vector2>().x.Equals(0f) &&
                        _airHero.PlayerInput.XBOX.Aim.ReadValue<Vector2>().y.Equals(0f))
                    {
                        _p3CrossHairs.SetActive(false);
                    }
                    else
                    {
                        _p3CrossHairs.SetActive(true);
                    }
                    _p3CrossHairs.transform.position = new Vector3(
                                      _airHero.transform.position.x + (_airHero.PlayerInput.XBOX.Aim.ReadValue<Vector2>().x * 5.5f),
                                      _airHero.transform.position.y + _airHero.PlayerInput.XBOX.Aim.ReadValue<Vector2>().y * 5.5f);
                    break;
                default:
                    break;
            }
        }
        if (_earthHero.TryGetComponent<HeroMovement>(out HeroMovement earthMovment))
        {
            switch (earthMovment.ControllerInput)
            {
                case HeroMovement.Controller.None:
                    break;
                case HeroMovement.Controller.Keyboard:
                    _p4Target = transform.GetComponent<Camera>().ScreenToWorldPoint(_earthHero.PlayerInput.KeyboardMouse.Aim.ReadValue<Vector2>());
                    _p4CrossHairs.transform.position = new Vector3(_p4Target.x, _p4Target.y);
                    break;
                case HeroMovement.Controller.PS4:
                    _p4CrossHairs.transform.SetParent(_earthHero.transform);
                    if (_earthHero.PlayerInput.PS4.Aim.ReadValue<Vector2>().x.Equals(0f) &&
                        _earthHero.PlayerInput.PS4.Aim.ReadValue<Vector2>().y.Equals(0f))
                    {
                        _p4CrossHairs.SetActive(false);
                    }
                    else
                    {
                        _p4CrossHairs.SetActive(true);
                    }
                    _p4CrossHairs.transform.position = new Vector3(
                                      _earthHero.transform.position.x + (_earthHero.PlayerInput.PS4.Aim.ReadValue<Vector2>().x * 5.5f),
                                      _earthHero.transform.position.y + _earthHero.PlayerInput.PS4.Aim.ReadValue<Vector2>().y * 5.5f);
                    break;
                case HeroMovement.Controller.XBOX:
                    _p4CrossHairs.transform.SetParent(_earthHero.transform);

                    if (_earthHero.PlayerInput.XBOX.Aim.ReadValue<Vector2>().x.Equals(0f) &&
                        _earthHero.PlayerInput.XBOX.Aim.ReadValue<Vector2>().y.Equals(0f))
                    {
                        _p4CrossHairs.SetActive(false);
                    }
                    else
                    {
                        _p4CrossHairs.SetActive(true);
                    }
                    _p4CrossHairs.transform.position = new Vector3(
                                      _earthHero.transform.position.x + (_earthHero.PlayerInput.XBOX.Aim.ReadValue<Vector2>().x * 5.5f),
                                      _earthHero.transform.position.y + _earthHero.PlayerInput.XBOX.Aim.ReadValue<Vector2>().y * 5.5f);
                    break;
                default:
                    break;
            }
        }
    }
}
