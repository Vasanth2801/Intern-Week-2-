using UnityEngine;

public class AudioManagerForMusicandShooting : MonoBehaviour
{
    public static AudioManagerForMusicandShooting instance; // Singleton pattern instance


    [Header("Audio Sources and Clips for background music")]
    [SerializeField] private AudioSource musicSource; // Audio source for background music
    [SerializeField] private AudioClip backgroundMusic; // Background music clip


    [Header("Audio Sources and Clips for shooting sound")]
    [SerializeField] private AudioSource clipSource;    // Audio source for shooting sound
    [SerializeField] private AudioClip shootSound; // Shooting sound clip


    [Header("Audio Sources and clips for enemy death sound")]
    [SerializeField] private AudioSource enemyDeathSource; // Audio source for enemy death sound
    [SerializeField] private AudioClip enemyDeathSound; // Enemy death sound clip

    private void Awake()
    {
        // Singleton implementation
        if (instance == null) // Checking if there is any other instance is called
        {
            instance = this; // If not, call this instance
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject); // If an instance already exists, destroy this duplicate
        }
    }

    private void Start()
    {
        PlayMusic();
    }

    void PlayMusic()
    {
        if(musicSource != null && backgroundMusic != null)
        {
            musicSource.clip = backgroundMusic; // Set the background music clip
            musicSource.Play(); // Play the background music
            musicSource.loop = true; // Loop the background music
        }
    }

    public void PlayShoot()
    {
        if (clipSource != null)
        {
            clipSource.PlayOneShot(shootSound); // Play shooting sound
        }
    }

    public void PlayEnemyDeath()
    {
        if (enemyDeathSource != null)
        {
            enemyDeathSource.PlayOneShot(enemyDeathSound); // Play enemy death sound
        }
    }
}
