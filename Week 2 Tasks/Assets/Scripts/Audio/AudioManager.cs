using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;                // Singleton pattern instance 

    [SerializeField] private AudioSource musicSource;      // reference to the audio source to be added in the inspector
    [SerializeField] private AudioClip coinSound;          // reference to the music sound downloaded 


    // Calls before the first frame of the game 
    void Awake()
    {
        // singleton implementation
        if(instance == null)                 // checking if there is any other instance is called 
        {
            instance = this;            // if not call this instance
        }
    }

   // Public method to play the coin sound 
    public void CoinSound()
    {
        if(musicSource != null)               // checking for the music source
        {
            musicSource.PlayOneShot(coinSound);     // if not play this sound 
        }

    }
}
