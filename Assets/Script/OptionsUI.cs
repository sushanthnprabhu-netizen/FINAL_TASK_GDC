using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsUI : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        volumeSlider.value = AudioManager.Instance.musicSource.volume;

        volumeSlider.onValueChanged.AddListener(ChangeVolume);
    }

    void ChangeVolume(float volume)
    {
        AudioManager.Instance.SetVolume(volume);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}