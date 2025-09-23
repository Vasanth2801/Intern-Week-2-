using UnityEngine;

public class AnotherAudioManager : MonoBehaviour
{
    public Sound[] sounds;


    private void Awake()
    {
        

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>(); // Add an audio source component to the game object
            s.source.clip = s.clip; // Assign the audio clip to the audio source
            s.source.volume = s.volume; // Assign the volume to the audio source
            s.source.pitch = s.pitch; // Assign the pitch to the audio source
            s.source.loop = s.loop; // Do not loop the sound
        }
    }

    private void Start()
    {
        Play("BackgroundMusic"); // Play background music at the start
    }


    public void Play(string name)
    {
        Sound s = System.Array.Find(sounds, sound => sound.name == name); // Find the sound with the given name
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!"); // Log a warning if the sound is not found
            return;
        }
        s.source.Play(); // Play the sound
    }
}
