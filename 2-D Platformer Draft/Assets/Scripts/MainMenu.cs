using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public AudioSource audioPlayer;
    // For the buttons displayed on menu
    public void StartButton()

    {
        audioPlayer.Play();
        SceneManager.LoadScene("Level1");
    }
    public void OptionsButton()
    {
        audioPlayer.Play();
        SceneManager.LoadScene("Options");
    }
    public void QuitButton()
    {
        audioPlayer.Play();
        Application.Quit();
    }
    public void CreditsButton()
    {
        audioPlayer.Play();
        SceneManager.LoadScene("Credits");
    }
}
