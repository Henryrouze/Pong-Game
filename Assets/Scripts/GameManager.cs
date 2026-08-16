using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    public int score1 = 0;
    public int score2 = 0;
    public GameObject ball;
    public TextMeshProUGUI scoreText;
    public void Goal1()
    {
        score1++;
        UpdateScoreText();
        GameOver();
    }

    public void Goal2()
    {
        score2++;
        UpdateScoreText();
        GameOver();
    }
    private void UpdateScoreText()
    {
        scoreText.text = score1.ToString() + " : " + score2.ToString();
    }
    private void GameOver()
    {
        if (score1 >= 5)
        {
            GameMode.isPlayer1Wins = true;
            GameMode.isPlayer2Wins = false;
            SceneManager.LoadScene("Game Over");
        }
        else if (score2 >= 5)
        {
            GameMode.isPlayer1Wins = false;
            GameMode.isPlayer2Wins = true;
            SceneManager.LoadScene("Game Over");
        }
    }
}
