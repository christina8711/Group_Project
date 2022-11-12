using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelCompleted : MonoBehaviour
{
    public GameObject WinDisplay;
    private Animator anim;
    public GameObject Player;
    public AudioSource audioPlayer;
    private void Start()
    {
        anim = GetComponent<Animator>();
        WinDisplay.SetActive(false);
        Player.SetActive(true);

    }
    //tracks if Player touches treasure and will move to next level
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            audioPlayer.Play();
            StartCoroutine(WinMenu());
        }
    }
    IEnumerator WinMenu()
    {
        // Play treasure animation
        anim.SetTrigger("Open Chest");
        //wait
        yield return new WaitForSeconds(1.7f);
        // Load Win Menu
        WinDisplay.SetActive(true);
        Player.SetActive(false);
        anim.SetTrigger("Stays Open");
    }
}

