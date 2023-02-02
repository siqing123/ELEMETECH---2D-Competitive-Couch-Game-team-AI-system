using System.Collections;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    private HeroActions _heroActions;
    private PlayerInput _playerInput;
    private Animator _playerAnimator;
    private CapsuleCollider2D _capsuleCollider;
    private Collider2D _col2D;
    private AnimationEvents _animationEvents;
    private Rigidbody2D _rb;

    public enum Controller
    {
        None,
        Keyboard,
        PS4,
        XBOX,
        Gamepad
    }
    public Controller ControllerInput = Controller.None;

    private float _horizontalMove;
    private float _moveInput;
    private bool _onHitLeft = false;
    private float _originalGravity;
    private float _originalRecoveryTime;

    [SerializeField] private float _moveSpeed = 12f;
    [SerializeField] private bool _isLeft = false;
    [SerializeField] private bool _isJumping = false;
    [SerializeField] private float _jumpForce = 5f;
    [SerializeField] private int _numOfJumps = 0;
    [SerializeField] private int _maxJumps = 1;
    [SerializeField] private int _numOfWallJumps = 0;
    [SerializeField] private int _maxWallJump = 1;
    [SerializeField] private LayerMask _whatIsGround;
    [SerializeField] private LayerMask _whatIsWall;

    //Dash Modifiers
    [SerializeField] private bool _canDash = true;
    [SerializeField] private bool _isDashing;
    [SerializeField] private float _dashSpeed = 5f;
    [SerializeField] private float _dashCoolDown = 1f;
    [SerializeField] private float _dashTime = 1f;
    [SerializeField] private float _dashStartUpTime = 1f;

    //Recovery Time until the player can move again 
    [SerializeField] private float _recoveryTime = 1f;
    [SerializeField] private bool _isRecovering = false;
    
    [SerializeField] private float _knockBackRecieved;
    [SerializeField] private float _knockBackCount;

    [SerializeField] private PhysicsMaterial2D _noFriction;
    [SerializeField] private PhysicsMaterial2D _fullFriction;
    [SerializeField] private float _slopeCheckDistance;
    [SerializeField] private float _maxSlopeAngle;
    private float _slopeDownAngle;
    private float _slopeSideAngle;
    private float _slopeDownAngleOld;
    private bool _isOnSlope;
    private bool _canWalkOnSlope;
    private Vector2 _newVelocity;
    private Vector2 _newForce;
    private Vector2 _col2DSize;
    private Vector2 _slopeNormalPerp;

    //Getters and Setters
    public CapsuleCollider2D GetBoxCollider2D { get => _capsuleCollider;  }
    public PlayerInput PlayerInput { get => _playerInput; } 
    public bool Dashing { get => _isDashing; } 
    public float Speed { get => _moveSpeed;  set => _moveSpeed = value; } 
    public bool GetIsLeft { get  => _isLeft; } 
    public float RecoveryTime { get => _recoveryTime;  set => _recoveryTime = value; } 
    public bool Recovering { get => _isRecovering;  set => _isRecovering = value; }
    
    private void Awake()
    {
        _playerAnimator = GetComponentInChildren<Animator>();
        _rb = GetComponent<Rigidbody2D>();
        _playerInput = new PlayerInput();
        _col2D = GetComponent<Collider2D>();
        _heroActions = GetComponent<HeroActions>();
        _originalRecoveryTime = _recoveryTime;
        _animationEvents = GetComponentInChildren<AnimationEvents>();
        _capsuleCollider = GetComponent<CapsuleCollider2D>();
        _col2DSize = _capsuleCollider.size;
        _canDash = true;
        if (ControllerInput == Controller.Keyboard)
        {
            _playerInput.KeyboardMouse.Dash.performed += _ => OnDash();
        }
        if (ControllerInput == Controller.PS4)
        {
            _playerInput.PS4.Dash.performed += _ => OnDash();
        }
        if (ControllerInput == Controller.XBOX)
        {
            _playerInput.XBOX.Dash.performed += _ => OnDash();
        }
        if (ControllerInput == Controller.Gamepad)
        {
            _playerInput.Gamepad.Dash.performed += _ => OnDash();
        }
    }

    private void Start()
    {
        _playerAnimator.SetBool("IsJumping", false);
        _originalGravity = _rb.gravityScale;
    }
    private void FixedUpdate()
    {
        if (IsGrounded())
        {
            _playerAnimator.SetBool("IsJumping", false);
            _playerAnimator.SetBool("IsMultiJump", false);
            _numOfJumps = _maxJumps;
            _numOfWallJumps = _maxWallJump;
        }

        SlopeCheck();
        if (!_isRecovering)
        {
            if (ControllerInput == Controller.Keyboard && !_isDashing)
            {
                _moveInput = _playerInput.KeyboardMouse.Move.ReadValue<float>();
            }
            if (ControllerInput == Controller.PS4 && !_isDashing)
            {
                _moveInput = _playerInput.PS4.Move.ReadValue<float>();
            }
            if (ControllerInput == Controller.XBOX && !_isDashing)
            {
                _moveInput = _playerInput.XBOX.Move.ReadValue<float>();
            }
            if (ControllerInput == Controller.Gamepad && !_isDashing)
            {
                _moveInput = _playerInput.Gamepad.Move.ReadValue<float>();
            }            
        }

        _newVelocity.Set(_moveSpeed * _moveInput, _rb.velocity.y);
        _rb.velocity = _newVelocity;

        if (_knockBackCount > 0)
        {
            if (_onHitLeft)
            {
                _rb.velocity = new Vector2(-_knockBackRecieved, _knockBackRecieved);
            }
            else
            {
                _rb.velocity = new Vector2(_knockBackRecieved, _knockBackRecieved);
            }
            _knockBackCount--;
        }

        if (_isDashing)
        {
            StartCoroutine(Dash(_isLeft));
        }

        if (_isRecovering)
        {
            StartCoroutine(Recover());
        }

        Vector3 characterScale = transform.localScale;
        if (_moveInput < 0)
        {
            characterScale.x = -1;
            _isLeft = true;
        }

        if (_moveInput > 0)
        {
            characterScale.x = 1;
            _isLeft = false;
        }

        transform.localScale = characterScale;
    }

    private void Update()
    {
        switch (ControllerInput)
        {
            case Controller.None:
                break;
            case Controller.Keyboard:
                if (_playerInput.KeyboardMouse.Jump.triggered && _numOfJumps > 0 || _playerInput.KeyboardMouse.Jump.triggered && IsWall() && _numOfWallJumps >0)
                {
                    Jump();
                }
                break;
            case Controller.PS4:
                if (_playerInput.PS4.Jump.triggered && _numOfJumps > 0 || _playerInput.KeyboardMouse.Jump.triggered && IsWall() && _numOfWallJumps > 0)
                {
                    Jump();
                }
                break;
            case Controller.XBOX:
                if (_playerInput.XBOX.Jump.triggered && _numOfJumps > 0 || _playerInput.KeyboardMouse.Jump.triggered && IsWall() && _numOfWallJumps > 0)
                {
                    Jump();
                }
                break;
            case Controller.Gamepad:
                if (_playerInput.Gamepad.Jump.triggered && _numOfJumps > 0)
                {
                    Jump();
                }
                break;
            default:
                break;
        }
        _horizontalMove = _moveInput * _moveSpeed;
        _playerAnimator.SetFloat("Speed", Mathf.Abs(_horizontalMove));
        if (IsWall())
        {

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.tag.Equals("Team1"))
        {
            if (collision.collider.tag.Equals("Team1"))
            {
                Physics2D.IgnoreCollision(_capsuleCollider, collision.collider,true);
            }
        }
        if (this.tag.Equals("Team2"))
        {
            if (collision.collider.tag.Equals("Team2"))
            {
                Physics2D.IgnoreCollision(_capsuleCollider, collision.collider, true);
            }
        }
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }
    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void SlopeCheck()
    {
        Vector2 checkPos = transform.position -  (Vector3)(new Vector2(0.0f, _col2DSize.y / 2));
        SlopeCheckHorizontal(checkPos);
        SlopeCheckVertical(checkPos);
    }

    private void SlopeCheckHorizontal(Vector2 checkPos)
    {
        RaycastHit2D slopeHitFront = Physics2D.Raycast(checkPos, transform.right, _slopeCheckDistance,_whatIsGround);
        RaycastHit2D slopeHitBack = Physics2D.Raycast(checkPos, -transform.right, _slopeCheckDistance, _whatIsGround);
        if(slopeHitFront)
        {
            _isOnSlope = true;
            _slopeSideAngle = Vector2.Angle(slopeHitFront.normal, Vector2.up);
        }
        else if(slopeHitBack)
        {
            _isOnSlope = true;
            _slopeSideAngle = Vector2.Angle(slopeHitBack.normal, Vector2.up);
        }
        else
        {
            _slopeSideAngle = 0.0f;
            _isOnSlope = false;
        }
    }

    private void SlopeCheckVertical(Vector2 checkPos)
    {
        RaycastHit2D hit = Physics2D.Raycast(checkPos, Vector2.down, _slopeCheckDistance, _whatIsGround);
        if (hit)
        {
            _slopeNormalPerp = Vector2.Perpendicular(hit.normal).normalized;
            //Return angle between y-axis and our normal
            _slopeDownAngle = Vector2.Angle(hit.normal, Vector2.up);
            if (_slopeDownAngle != _slopeDownAngleOld)
            {
                _isOnSlope = true;
            }
            _slopeDownAngleOld = _slopeDownAngle;
            Debug.DrawRay(hit.point, _slopeNormalPerp, Color.red);
            Debug.DrawRay(hit.point, hit.normal,Color.green);
        }
        if(_isOnSlope && _moveInput == 0.0f)
        {
            _rb.sharedMaterial = _fullFriction;
        }
        else
        {
            _rb.sharedMaterial = _noFriction;
        }
    }

    public void IcySlidding(float SliddingSpeed)
    {
        _moveSpeed += SliddingSpeed;
    }

    public void SandDecrease(float SandDecreaseSpeed)
    {
        _moveSpeed -= SandDecreaseSpeed;
    }

    public bool IsGrounded()
    {
        float extraHeightText = .05f;
        RaycastHit2D raycastHit2D = Physics2D.Raycast(_capsuleCollider.bounds.center, Vector2.down, _capsuleCollider.bounds.extents.y + extraHeightText, _whatIsGround);
        //Color rayColor;
        //if (raycastHit2D.collider != null)
        //{
        //    rayColor = Color.green;
        //}
        //else
        //{
        //    rayColor = Color.red;
        //}
        //Debug.DrawRay(_capsuleCollider.bounds.center, Vector2.down * (_capsuleCollider.bounds.extents.y + extraHeightText),rayColor);
        return raycastHit2D.collider != null;
    }

    public bool IsWall()
    {
        float extraLengthText = .15f;
        RaycastHit2D raycastHit2DLeft = Physics2D.Raycast(_col2D.bounds.center , Vector2.left, -(_col2D.bounds.extents.x + extraLengthText), _whatIsWall);
        RaycastHit2D raycastHit2DRight = Physics2D.Raycast(_col2D.bounds.center, Vector2.left, (_col2D.bounds.extents.x + extraLengthText), _whatIsWall);
        Color rayColor;
        if (raycastHit2DLeft.collider != null || raycastHit2DRight.collider != null)
        {
            rayColor = Color.green;
        }
        else
        {
            rayColor = Color.red;
        }
        Debug.DrawRay(_col2D.bounds.center, Vector2.left * -(_col2D.bounds.extents.x + extraLengthText), rayColor);
        Debug.DrawRay(_col2D.bounds.center, Vector2.left * (_col2D.bounds.extents.x + extraLengthText), rayColor);
        if (raycastHit2DLeft.collider != null)
        {
            return true;
        }
        else if (raycastHit2DRight.collider != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void OnDash()
    {
        if (_canDash)
        {
            _playerAnimator.SetTrigger("DashTrigger");
            _isDashing = true;
        }
    }

    private void Jump()
    {
        _playerAnimator.SetBool("IsJumping", true);

        _rb.velocity = Vector2.up * _jumpForce;
        _numOfJumps--;
        if (IsWall())
        {
            _numOfWallJumps--;
        }
    }

    public void OnKnockBackHit(float knockbackamount, bool direction)
    {
        _knockBackCount++;
        _knockBackRecieved = knockbackamount;
        _onHitLeft = direction;
    }

    IEnumerator Dash(bool _isLeft)
    {        
        if (_isLeft)
        {
            _rb.velocity = Vector2.left * _dashSpeed;
        }
        else
        {
            _rb.velocity = Vector2.right * _dashSpeed;
        }
        _rb.gravityScale = 0f;
        yield return new WaitForSeconds(_dashStartUpTime);
        _rb.velocity = Vector2.zero;
        _rb.gravityScale = _originalGravity;
        _isDashing = false;
        _canDash = false;
        _isRecovering = true;
        yield return new WaitForSeconds(_dashCoolDown);
        _canDash = true;
    }

    IEnumerator Recover()
    {
        _heroActions.enabled = false;
        _isRecovering = true;
        yield return new WaitForSeconds(_recoveryTime);
        _recoveryTime = _originalRecoveryTime;
        _heroActions.enabled = true;
        _isRecovering = false;
    }
}
