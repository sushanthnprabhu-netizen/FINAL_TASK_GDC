using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OpenOptions()
    {
        SceneManager.LoadScene("OptionsScene");
    }

    public void QuitGame()
    {
        Debug.Log("Game Exited");
    }
}