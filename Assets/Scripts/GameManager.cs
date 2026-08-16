using UnityEngine;
using TMPro;

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
    }

    public void Goal2()
    {
        score2++;
        UpdateScoreText();
    }
    private void UpdateScoreText()
    {
        scoreText.text = score1.ToString() + " : " + score2.ToString();
    }
    
}
