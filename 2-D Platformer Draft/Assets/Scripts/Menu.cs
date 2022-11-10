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

    // For the buttons displayed on menu
    public void RestartButton()
    {
        SceneManager.LoadScene("Level1");
        Coins.ResetEffect();
        Time.timeScale = 1;
        Jumping.enabled = true;
    }
    public void NextLevelButton()
    {
        SceneManager.LoadScene("Level2");
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
        Coins.ResetEffect();
        Time.timeScale = 1;
        Jumping.enabled = true;

    }
    public void BackButton()
    {
        OptionsDisplay.SetActive(false);
        Time.timeScale = 1;
        Jumping.enabled = true;

    }
}
