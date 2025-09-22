using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] private Animator playerAnimation;    //Reference for the animator we have created for playing the animations
    [SerializeField] private float moveSpeed;                    // Player movement speed
    Rigidbody2D rb;                                        // Rigidbody References
    [SerializeField] private float jumpForce;                    // Player jump force
    bool isGrounded = false;                                        // To check if the player is grounded


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        HorizontalMovement();
        Jumping();
    }

    void HorizontalMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");       //To get the horizontal axis value
        rb.linearVelocity = new Vector2(horizontal * moveSpeed, rb.linearVelocity.y);  //Setting the velocity of the player
        //Setting the parameters for the animator
        playerAnimation.SetFloat("Speed", Mathf.Abs(horizontal));   //Setting the speed parameter in animator
                         
        //Flipping the player based on movement direction
        if (horizontal > 0)
            transform.localScale = new Vector3(1, 1, 1);   //Facing Right
        else if (horizontal < 0)
            transform.localScale = new Vector3(-1, 1, 1);  //Facing Left
    }

    void Jumping()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);      //Setting the velocity of the player
            playerAnimation.SetBool("isJumping", true);   //Setting the isJumping parameter in animator
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;   //Player is grounded
            playerAnimation.SetBool("isJumping", false);   //Setting the isJumping parameter in animator
        }
    }
}