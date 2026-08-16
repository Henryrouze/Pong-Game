using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI player1WinsText;
    public TextMeshProUGUI player2WinsText;
    void Start()
    {
        if (GameMode.isPlayer1Wins)
        {
            player1WinsText.enabled = true;
        }
        else if (GameMode.isPlayer2Wins)
        {
            player2WinsText.enabled = true;
        }
    }
}
