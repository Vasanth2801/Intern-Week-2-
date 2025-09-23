using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 20f;          // Speed of the bullet
    [SerializeField] private float lifeTime = 2f;        // Lifetime of the bullet
    private float lifeTimer;                             // Timer to track the lifetime
    Rigidbody2D rb;                                       // Reference to the Rigidbody2D component

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();                 // Get the Rigidbody2D component
    }


    void OnEnable()
    {
        lifeTimer = lifeTime;                                  // Reset the timer when the bullet is enabled
        if(rb != null)
        {
            rb.linearVelocity = transform.up * speed;                // Set the velocity of the bullet
        }  
    }

    void Update()
    {
        lifeTimer -= Time.deltaTime;                           // Decrease the timer
        if (lifeTimer <= 0f)
        {
            gameObject.SetActive(false);                       // Deactivate the bullet when the timer is up
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);                        // Destroy the enemy on collision
            gameObject.SetActive(false);                           // Deactivate the bullet on collision
        }
        
    }
}
