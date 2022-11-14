using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public PlayerMovement Jumping;
    public AudioSource audioPlayer;
    bool isPaused = false;
    public void pauseGame()
    {
        //Plays audio when Pause button is pressed
        audioPlayer.Play();
        //If button is not pressed then game will not be paused
        if (isPaused)
        { 
            Time.timeScale = 1;
            isPaused = false;
            Jumping.enabled = true;
        }
        //If button is pressed then game will be paused
        else
        {
            Time.timeScale = 0;
            isPaused = true;
            Jumping.enabled = false;
        }
        
    }
}

