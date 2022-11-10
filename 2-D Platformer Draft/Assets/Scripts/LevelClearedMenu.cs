using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelClearedMenu : MonoBehaviour
{
    // For the buttons displayed on menu
    public void RestartButton()
    {
        SceneManager.LoadScene("Level1");
    }
    public void NextLevelButton()
    {
        SceneManager.LoadScene("Level2");
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
