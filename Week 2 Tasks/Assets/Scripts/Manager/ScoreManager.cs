using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;                 //Singleton pattern implementation forScoreManager
    [SerializeField] private int currentScore = 0;                  //variable for the score to increase
    [SerializeField] private TextMeshProUGUI scoreText;      // score for the UI to show
    [SerializeField] private TextMeshProUGUI highScoreText;  //Score for the UI to show the highest score 



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
    
    // Called at first fram of the game 
    private void Start()
    {
        scoreText.text = "Score: " + currentScore.ToString();          // score at start of the game which is zero
        highScoreText.text = "HighScore: " + HighScoreManager.instance.GetHighScore();      //High score while starting if zero it is zero orelse the score we which is highest 
    }

    // Called for every frame
    private void Update()
    {
        UpdateScore();       //Method to update the score 
    }

    // public method to call the score from other script 
    public void AddScore()
    {
        currentScore++;                                                   //Increasing the Score by 1
        if(currentScore > HighScoreManager.instance.GetHighScore())      //checking if current score is higher than zero 
        {
            PlayerPrefs.SetInt("HighScore", currentScore);                 //Then show the highest score in UI
            highScoreText.text = "HighScore: " + currentScore;             // Then store that  score in as highest score
        }
       
    } 

    // Method to update the score in UI
    void UpdateScore()
    {
        scoreText.text = "Score: " + currentScore.ToString();      // telling the text to update the score by converting the int to string as the text is string 
    }
}
