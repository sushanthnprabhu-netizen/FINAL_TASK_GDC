using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneUI : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}