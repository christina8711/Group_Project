using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsButton : MonoBehaviour
{
    public GameObject OptionsDisplay;
    public PlayerMovement Jumping;
    bool isPaused = false;
    private void Start()
    {

    }
    public void pauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
            Jumping.enabled = true;
            OptionsDisplay.SetActive(false);

        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
            Jumping.enabled = false;
            OptionsDisplay.SetActive(true);

        }

    }
}
