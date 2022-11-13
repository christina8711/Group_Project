using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public CoinScript Coins;
    public GameObject OptionsDisplay;
    public PlayerMovement Jumping;
    public AudioSource audioPlayer;
    // For the buttons displayed on menu
    public void RestartButton()
    {
        audioPlayer.Play();
        SceneManager.LoadScene("Level1");
        OptionsDisplay.SetActive(false);
        Coins.ResetEffect();
        Time.timeScale = 1;
        Jumping.enabled = true;
    }
    public void RestartButton2()
    {
        audioPlayer.Play();
        SceneManager.LoadScene("Level2");
        OptionsDisplay.SetActive(false);
        Coins.ResetEffect();
        Time.timeScale = 1;
        Jumping.enabled = true;
    }
    public void NextLevelButton()
    {
        audioPlayer.Play();
        SceneManager.LoadScene("Level2");
    }
    public void MainMenuButton()
    {
        audioPlayer.Play();
        SceneManager.LoadScene("MainMenu");
        Coins.ResetEffect();
        Time.timeScale = 1;
        Jumping.enabled = true;

    }
    public void BackButton()
    {
        audioPlayer.Play();
        OptionsDisplay.SetActive(false);
        Time.timeScale = 1;
        Jumping.enabled = true;

    }
}
