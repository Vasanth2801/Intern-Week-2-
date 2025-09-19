using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemySpawner enemySpawner;          //  Reference to the EnemySpawner script

    //Called before the first frame update
    private void Start()
    {
        enemySpawner = GetComponentInParent<EnemySpawner>();      //Getting the reference of the EnemySpawner script from the parent object
    }

    //used to the physcics touching objects
    private void OnCollisionEnter2D(Collision2D other)
    { 
        if(other.collider.CompareTag("Ground"))      // if gameobject collides with the ground
        {
            Destroy(gameObject);              //destroy the enemy gameobject

            enemySpawner.waves[enemySpawner.currentWave].enemiesCount--;      //decreasing the enemy count in the current wave
        }

        if(other.collider.CompareTag("Player"))             // if gameobject collides with the player
        {
            Debug.Log("Player Hit");
            Destroy(other.gameObject);                    //destroy the player
            Destroy(gameObject);                           //destroy the enemy
            enemySpawner.waves[enemySpawner.currentWave].enemiesCount--;      //decreasing the enemy count in the current wave
        }
    }
}
