using System.Collections;
using UnityEngine;
using TMPro;

public class EnemySpawner : MonoBehaviour
{
    [System.Serializable]                             //Making the class serializable to view in the inspector
    public class Wave
    {
        public  Enemy[] enemies;                //Using the array to store the enemies that need to be spawned
        public float timeBetweenSpawns = 3f;      //Time interval between spawning the enemies
        public float timeBetweenWaves = 10f;      //Time interval between spawning the waves
        public int enemiesCount;                    //Number of enemies in the wave
    }

    [Header("Wave Settings")]
    [SerializeField] private float countDown;            //Time interval for spawning the waves 
    public  Wave[] waves;                                 //Array to store the waves that can be spawned 
    public Transform[] spawnPoint;                       //Spawn point for the enemies
    public int currentWave = 0;                        //current wave that is being spawning from the array 
    private bool countDownBegin;                       //Bool to check if the countdown has begun or not
    [SerializeField] private TextMeshProUGUI waveCountDownText; //Text to display the countdown timer


    // called at the first frame of the update
    private void Start()
    {
        countDownBegin = true;                        //Starting the countdown when the game starts
        for (int i = 0; i < waves.Length; i++)             // going through each wave in the array
        {
            waves[i].enemiesCount = waves[i].enemies.Length;      //Setting the enemy count for each wave based on the no.of enemies in the array 
        }
        waveCountDownText.text = "wave: " + currentWave.ToString();       //instailizing the wave count text
    }

    // called for every second frame
    private void Update()
    {
        waveCountDownText.text = "wave: " + currentWave.ToString();       //Updating the wave count text in the current frame
        if (currentWave >= waves.Length)                                  //Checking if all the waves are completed
        {
            Debug.Log("All Waves Completed!");          //Debugging when all the waves are completed
            return;
        }
        if (countDownBegin == true)                      // Checking if the countdown has begun
        {
            countDown -= Time.deltaTime;                  //Decreasing the countdown time when the game start running
        }
       

        if(countDown <= 0f)                              //if countdown reaches zero
        {
            countDownBegin = false;                      //Stopping the countdown when the wave is spawned
            countDown = waves[currentWave].timeBetweenWaves;   // Resetting the countdown timer for the waves to spawn
            //Spawn the Wave 
            StartCoroutine(SpawnWave());
        }

        if (waves[currentWave].enemiesCount == 0)                  // if it reaches zero it means the wave is cleared
        {
            countDownBegin = true;                       //Starting the countdown when the wave is cleared
            currentWave++;                              //Increasing the wave index to spawn the next wave
        }
    }


    // coroutine to spawn the wave of enemies
    IEnumerator SpawnWave()
    {
        if(currentWave < waves.Length)                 // checking if the wave number is less than the total number of waves
        {
            for (int i = 0; i < waves[currentWave].enemies.Length; i++)         // going through each enemy in the current wave
            {
                Transform spawnPoints = spawnPoint[Random.Range(0,spawnPoint.Length)]; //Choosing a random spawn point from the array
                Enemy enemy = Instantiate(waves[currentWave].enemies[i],spawnPoints.position , Quaternion.identity);    //spawning the enemies at the spawn position
                enemy.transform.SetParent(spawnPoints);                                                     // Using it to store spawned enemies in the hierarchy under the spawn point for optimazation        
                yield return new WaitForSeconds(waves[currentWave].timeBetweenSpawns);                   //waiting for time between spawning the enemies 
            }
            Debug.Log("Wave Spawned");                    //Debugging the wave spawning 
        }
    }
}
