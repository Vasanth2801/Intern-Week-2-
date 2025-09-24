using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] private float speed = 2f;      // Speed of the enemy
    [SerializeField] private Transform player;    // Reference to the player's transform

    void Start()
    {
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;          // Find the player by tag if not assigned
        }
    }
    void Update()
    {
        if(player != null) // Check if player is assigned
        {
            // Move towards the player
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            GameManager.instance.GameOver(); // Call the Restart method from GameManager
            Debug.Log("Enemy collided with Player");
        }
    }
}