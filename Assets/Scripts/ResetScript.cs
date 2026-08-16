using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScript : MonoBehaviour
{
    public void onclick()
    {
        GameMode.isPlayer1Wins = false;
        GameMode.isPlayer2Wins = false;
        SceneManager.LoadScene("Main Menu");
    }
}
