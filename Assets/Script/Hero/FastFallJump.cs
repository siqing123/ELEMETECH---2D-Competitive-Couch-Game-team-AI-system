using UnityEngine;

public class FastFallJump : MonoBehaviour
{
    [SerializeField]
    private float _fallMultiplier = 2.5f;
    //[SerializeField]
    //private float mLowJumpMultiplier = 2f;

    Rigidbody2D _rb;
    private HeroMovement mHeroMovement;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        mHeroMovement = GetComponent<HeroMovement>();
    }

    private void FixedUpdate()
    {
        if(_rb.velocity.y < 0)
        {
            _rb.velocity += Vector2.up * Physics2D.gravity.y * (_fallMultiplier - 1) * Time.deltaTime;
        }
        //else if (_rb.velocity.y > 0 && 
        //    (!mHeroMovement.PlayerInput.KeyboardMouse.Jump.triggered || !mHeroMovement.PlayerInput.PS4.Jump.triggered || !mHeroMovement.PlayerInput.XBOX.Jump.triggered))
        //{
        //    _rb.velocity += Vector2.up * Physics2D.gravity.y * (mLowJumpMultiplier - 1) * Time.deltaTime;

        //}
    }
}
