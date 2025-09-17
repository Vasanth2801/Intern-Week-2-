using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    [SerializeField] private int score;            //Score varaible for the increasing when player touches the coin
    [SerializeField] private TextMeshProUGUI scoreText;      // Assign score text we created in inspector
    [SerializeField] private ParticleSystem coinEffect;      // Assign the coinparticles effect we created in the inspector

    // Called at the first frame of the update
    private void Start()
    {
        score = 0;      //intializing the score is 0 at start of the game when it starts
    }

    

    // Used for check the physics collisions between gameobjects 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))           // Checking whether the if collision happens it has player tag if correct pass in the logic
        {
            AudioManager.instance.CoinSound();                 // using singleton pattern to call the coin sound 
            score++;                                                     // increase the score by one
            coinEffect.Play();                                 //Playing the particle effects 
            scoreText.text = "Score: " + score.ToString();              // Updating the score to the scene textmeshpro                                                           // increase the score by one
            Debug.Log("Scored Increase and collision detected: " + score);
            Destroy(this.gameObject);
        }
    }
}    
