using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;              // Movement of the Player
    Rigidbody2D rb;                                        // Rigidbody References
    Vector2 movement;                                     // Movement for two axis 
    TopdownController controller;                         //Reference for InputActions

    //Awake Calls before Start Method
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        controller = new TopdownController();

        MovementCalling();                // A method to call the movement
    }

    //Method to Handle movement
    void MovementCalling()
    {
        controller.Player.Move.performed += ctx => movement = ctx.ReadValue<Vector2>();     //To read the value when button is pressed 
        controller.Player.Move.canceled += ctx => movement = Vector2.zero;                  //To read the value when it is canceled 
    }


    private void OnEnable()
    {
        controller.Player.Enable();
    }

    private void OnDisable()
    {
        controller.Player.Disable();
    }

    // Used for physics intervals
    void FixedUpdate()
    {
        HandleMovement();            //Method to Handle movement
    }

    //Handling the Movement
    void HandleMovement()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);     //For Moving the Player
    }
}
