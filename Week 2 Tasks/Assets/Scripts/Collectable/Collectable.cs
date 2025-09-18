using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            ScoreManager.instance.AddScore();
            Debug.Log("Score increased");
        }
    }
}
