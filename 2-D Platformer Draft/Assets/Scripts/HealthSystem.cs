using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public GameObject GameOverDisplay;
    public GameObject[] hearts; //[0] [1] [2]
    private int life; //3
    private bool dead;
    public GameObject Player;
    public AudioSource audioPlayer;

    // Start is called before the first frame update
    void Start()
    {
        life = hearts.Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (dead == true)
        {
            //Set Final death code
            Debug.Log("GameOver, Try again.");
            Destroy(Player);

        }
    }

    public void TakeDamage(int amount)
    {
        if (life >= 1)
        {
            life -= amount; // TotalHearts - 1 =
            audioPlayer.Play();
            Destroy(hearts[life].gameObject); //[0]
            if (life < 1)
            {
                dead = true;
                GameOverDisplay.SetActive(true);
            }
        }
    }



}
