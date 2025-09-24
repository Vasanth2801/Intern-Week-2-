using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;      //static instance of the GameManager class
    public static bool isGamePaused = false;  //boolean to check if the game is paused or not

    public GameObject pauseMenuUI;           //Gameobject for the pause menu UI
    public GameObject gameOverPanel;        //Gameobject for the game over panel

    void Awake()
    {
        if (instance == null)                 //if the instance is null
        {
            instance = this;                  //set the instance to this
            DontDestroyOnLoad(gameObject);   //do not destroy the game object on load
        }
        else if (instance != this)            //else if the instance is not this
        {
            Destroy(gameObject);              //destroy the game object
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))  //checking if the escape key is pressed
        {
            if (isGamePaused)                  //if the game is paused
            {
                Resume();                      //call the resume method
            }
            else
            {
                Pause();                       //else call the pause method
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);         //set the pause menu UI to false
        Time.timeScale = 1f;                  //set the time scale to 1f
        isGamePaused = false;                 //set the boolean to false
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);          //set the pause menu UI to true
        Time.timeScale = 0f;                  //set the time scale to 0f
        isGamePaused = true;                  //set the boolean to true
    }

    public void Menu()
    {
        Debug.Log("Menu button clicked"); // Log message to indicate the button was clicked
        Time.timeScale = 1f;              //set the time scale to 1f
        SceneManager.LoadScene(0); // Load the MainMenu scene
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);           // Load the Game scene
        Time.timeScale = 1f;              //set the time scale to 1f
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);       //set the game over panel to true
        Time.timeScale = 0f;                 //set the time scale to 0f
        isGamePaused = true;                 //set the boolean to true
    }
}
