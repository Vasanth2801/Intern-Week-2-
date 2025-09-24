using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // Method the Play button feature when the button is clicked in the start menu
    public void Play()
    {
        SceneManager.LoadScene(1);                        //Loading the 1 scene in the build profiles which is the game scene
    }

    // Method the Quit button feature when the button is clicked in the start menu
    public void Quit()
    {
        Debug.Log("QUIT!");                               //Logging the quit action to the console
        Application.Quit();                               //Quitting the application
    }
}
