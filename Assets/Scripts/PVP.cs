using UnityEngine;
using UnityEngine.SceneManagement;

public class PVP : MonoBehaviour
{
    public void OnClick()
    {
        GameMode.isPVE = false;
        SceneManager.LoadScene("Gameplay");
    }
}
