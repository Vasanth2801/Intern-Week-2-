using UnityEngine;

public class AudioManagerForMusicandShooting : MonoBehaviour
{
    public static AudioManagerForMusicandShooting instance; // Singleton pattern instance
    [SerializeField] private AudioSource musicSource; // Audio source for background music
    [SerializeField] private AudioClip backgroundMusic; // Background music clip

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
}
