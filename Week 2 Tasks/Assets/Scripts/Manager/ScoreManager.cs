 using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;                 //Singleton pattern implemntation forScoreManager
    [SerializeField] private int score;                  //variable for the score to increase


    // Awake calls before Start method
    private void Awake()
    {
        if(instance == null)                               //checking if there any other instance 
        {
            instance = this;                                // if not then use this instance
            DontDestroyOnLoad(gameObject);                  //Dont destroy this instance gameobject when game startss
        }
        else
        {
            Destroy(gameObject);                             //If there any other instance then destroy
        }
    }

    // public method to call the score from other script 
    public void AddScore()
    {
        score++;
    }
}
