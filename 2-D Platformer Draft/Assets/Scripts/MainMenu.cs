using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // For the buttons displayed on menu
    public void StartButton()
    {
        SceneManager.LoadScene("Level1");
    }
    public void OptionsButton()
    {
        SceneManager.LoadScene("Options");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void CreditsButton()
    {
        SceneManager.LoadScene("Credits");
    }
}
