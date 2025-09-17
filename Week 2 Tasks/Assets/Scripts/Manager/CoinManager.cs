using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance;
    [SerializeField] private int score;
    [SerializeField] private TextMeshProUGUI scoreText;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    private void Update()
    {
        UpdateScore(score);
    }
    public void AddScore()
    {
        score++;
    }

    

    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
