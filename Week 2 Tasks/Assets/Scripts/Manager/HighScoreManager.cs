using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    public static HighScoreManager instance;            // Singleton Implementation

    //Awake is called before start
    private void Awake()
    {
        if(instance == null)                  //Checking for the this instance 
        {
            instance = this;                       //if not choose this intancse 
            DontDestroyOnLoad(gameObject);           //dont destroy this instance 
        }
        else
        {
            Destroy(gameObject);             //destroy the instance 
        } 
    }


    //Method for setting the High score where at start of the game 
    public int GetHighScore()
    {
       return PlayerPrefs.GetInt("HighScore", 0);       //At start of the game the highest score is zero
    }

    
    //Reset the highest score to zero
    public void ResetHighScore()
    {
        PlayerPrefs.DeleteKey("HighScore");    //Delete the saved data and make it zero
        PlayerPrefs.Save();                          //Saving the data automatically
    }
}
