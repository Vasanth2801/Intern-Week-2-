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
        rb = GetComponent<Rigidbody2D>();         // calling the rigidbody component
    }

    void Update()
    {
        HorizontalMovement();         // For the player movemnt
        Jumping();                     // For the player jumping
    }

    //For the player movemnt 
    void HorizontalMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");       //To get the horizontal axis value for player moving left and right 
        rb.linearVelocity = new Vector2(horizontal * moveSpeed, rb.linearVelocity.y);  //Setting the velocity of the player
        //Setting the parameters for the animator
        playerAnimation.SetFloat("Speed", Mathf.Abs(horizontal));   //Setting the speed parameter in animator
                         
        //Flipping the player based on movement direction
        if (horizontal > 0)
            transform.localScale = new Vector3(1, 1, 1);   //Facing Right
        else if (horizontal < 0)
            transform.localScale = new Vector3(-1, 1, 1);  //Facing Left
    }

    // for the player jumping 
    void Jumping()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)       // if the player is in ground and jump button is pressed
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);      //Setting the velocity of the player
            playerAnimation.SetBool("isJumping", true);   //Setting the isJumping parameter in animator
        }
    }
    //Checking the physics collsiion
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))       // if the player collides with the ground
        {
            isGrounded = true;   //Player is grounded
            playerAnimation.SetBool("isJumping", false);   //Setting the isJumping parameter in animator
        }
    }
}