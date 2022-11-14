using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsButton : MonoBehaviour
{
    public AudioSource audioPlayer;
    public GameObject OptionsDisplay;
    public PlayerMovement Jumping;
    bool isPaused = false;
    public void pauseGame()
    {
        //Plays audio when Option button is pressed
        audioPlayer.Play();
        //If button is not pressed then game will not be paused and Option display will be disabled
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
            Jumping.enabled = true;
            OptionsDisplay.SetActive(false);

        }
        //If button is pressed then game will be paused and Option display will be enabled
        else
        {
            Time.timeScale = 0;
            isPaused = true;
            Jumping.enabled = false;
            OptionsDisplay.SetActive(true);

        }

    }
}
