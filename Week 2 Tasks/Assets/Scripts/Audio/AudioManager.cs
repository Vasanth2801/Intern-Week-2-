using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioClip coinSound;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    private void Update()
    {
        CoinSound();
    }

    public void CoinSound()
    {
        if(musicSource != null)
        {
            musicSource.PlayOneShot(coinSound);
        }

    }
}
