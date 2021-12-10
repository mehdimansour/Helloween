using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Transform GroundCheck;
    [SerializeField] LayerMask GroundLayer;

    [SerializeField] float speed = 80f;
    [SerializeField] float jumpingForce = 5f;

    [SerializeField] Hell HellVfx;
    float horizontal = 0;
    bool isLookingRight = true;
    string SatanTag = "Satan";
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HellVfx.Rate = (float)(gameObject.transform.position.y * -0.02);
    }

    private void FixedUpdate()
    {

        rb.velocity = new Vector2(horizontal * speed * Time.fixedDeltaTime, rb.velocity.y);
        if (!isLookingRight && horizontal > 0f)
        {
            FlipSprite();
        }
        else if (isLookingRight && horizontal < 0f)
        {
            FlipSprite();
        }

    }

    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(GroundCheck.position, 0.2f, GroundLayer);
    }

    private void FlipSprite()
    {
        isLookingRight = !isLookingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        horizontal = ctx.ReadValue<Vector2>().x;
    }

    public void Jump(InputAction.CallbackContext ctx)
    {
        if (ctx.performed && isGrounded())
        {
            // animator.SetTrigger("JumpTriggered");
            rb.velocity = new Vector2(rb.velocity.x, jumpingForce);
        }

        if (ctx.canceled && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingForce * 0.5f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == SatanTag)
        {
            NavigateMenu.SwitchScene("YouWinScene");
        }
    }
}
