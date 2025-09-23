using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;// Name of the sound
    public AudioClip clip; // Audio clip for the sound

    [Range(0f, 1f)]
    public float volume; // Volume of the sound
    [Range(0.1f, 3f)]
    public float pitch; // Pitch of the sound

    public bool loop; // Should the sound loop

    [HideInInspector]                              // Hide this field in the inspector since we call it in awake method
    public AudioSource source; // Audio source for the sound
}
