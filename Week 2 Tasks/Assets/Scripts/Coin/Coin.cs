using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    [SerializeField] private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;      // Assign score text we created in inspector
    [SerializeField] private GameObject coinEffect;      //

    // Used for check the physics collisions between gameobjects 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))           // Checking whether the if collision happens it has player tag if correct pass in the logic
        {
            CoinBehaviour();
            Instantiate(coinEffect,transform.position,Quaternion.identity);
        }
    }

    //Method for the coin
    void CoinBehaviour()
    {
        CoinManager.Instance.AddScore();      //scoring for the picking coin called using singleton
        AudioManager.instance.CoinSound();     //Audio for the coin 
;       Debug.Log("Coin picked up");
        Destroy(this.gameObject);          //destroying the coin
    }
}    
