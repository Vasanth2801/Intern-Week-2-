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

    private void Start()
    {
        scoreText.text = "Score: " + currentScore.ToString();
        highScoreText.text = "HighScore: " + HighScoreManager.instance.GetHighScore();
    }

    // Called for every frame
    private void Update()
    {
        UpdateScore();
    }

    // public method to call the score from other script 
    public void AddScore()
    {
        currentScore++;             //Increasing the Score by 1
        if(currentScore > HighScoreManager.instance.GetHighScore())
        {
            PlayerPrefs.SetInt("HighScore", currentScore);                 //To save the highscore we get
            highScoreText.text = "HighScore: " + currentScore;             //
        }
       
    } 

    // Method to update the score in UI
    void UpdateScore()
    {
        scoreText.text = "Score: " + currentScore.ToString();      // telling the text to update the score by converting the int to string as the text is string 
    }

}
