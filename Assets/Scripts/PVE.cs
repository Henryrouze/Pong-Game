using UnityEngine;
using UnityEngine.SceneManagement;

public class PVE : MonoBehaviour
{
    public void OnClick()
    {
        GameMode.isPVE = true;
        SceneManager.LoadScene("Gameplay");
    }
}
