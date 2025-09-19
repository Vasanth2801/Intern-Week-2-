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
    }
}
