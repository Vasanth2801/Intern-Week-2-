using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float countDown = 4f;            //Time interval for spawning the waves 


    private void Update()
    {
        countDown -= Time.deltaTime;                  //Decreasing the countdown time when the game start running

        if(countDown <= 0f)
        {
            //Spawn the Wave 
            SpawnWave();
        }
    }

    void SpawnWave()
    {
        Debug.Log("Wave Spawned");                    //Debugging the wave spawning 
        countDown = 4f;                                //Resetting the countdown again for spawning the next wave
    }
}
