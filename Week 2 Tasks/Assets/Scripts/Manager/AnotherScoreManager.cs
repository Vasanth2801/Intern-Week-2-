using UnityEngine;
using TMPro;

public class AnotherScoreManager : MonoBehaviour
{
    [SerializeField] private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;

    public static AnotherScoreManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddScore()
    {
        score++;
    }

    public int GetScore(int score)
    {
        return score;
    }
}
