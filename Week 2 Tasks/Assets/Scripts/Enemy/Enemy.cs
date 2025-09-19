using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemySpawner enemySpawner;

    private void Start()
    {
        enemySpawner = GetComponentInParent<EnemySpawner>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.CompareTag("Ground"))
        {
            Destroy(gameObject);

            enemySpawner.waves[enemySpawner.currentWave].enemiesCount--;
        }

        if(other.collider.CompareTag("Player"))
        {
            Debug.Log("Player Hit");
            Destroy(other.gameObject);
            Destroy(gameObject);
            enemySpawner.waves[enemySpawner.currentWave].enemiesCount--;
        }
    }
}
