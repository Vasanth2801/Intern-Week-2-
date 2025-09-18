using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;                 //Singleton pattern implementation forScoreManager
    [SerializeField] private int score;                  //variable for the score to increase
    [SerializeField] private TextMeshProUGUI scoreText;      //


    // Awake calls before Start method
    private void Awake()
    {
        if(instance == null)                               //checking if there any other instance 
        {
            instance = this;                                // if not then use this instance
            DontDestroyOnLoad(gameObject);                  //Dont destroy this instance gameobject when game start
        }
        else
        {
            Destroy(gameObject);                             //If there any other instance then destroy
        }
    }

    // Called for every frame
    private void Update()
    {
        UpdateScore();
    }

    // public method to call the score from other script 
    public void AddScore()
    {
        score++;             //Increasing the Score by 1
    }

    // Method to update the score in UI
    void UpdateScore()
    {
        scoreText.text = "Score: " + score.ToString();      // telling the text to update the score by converting the int to string as the text is string 
    }

}
