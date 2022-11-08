using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelCompleted : MonoBehaviour
{
    public GameObject WinDisplay;
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
        WinDisplay.SetActive(false);

    }
    //tracks if Player touches treasure and will move to next level
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(WinMenu());
        }
    }
    IEnumerator WinMenu()
    {
        // Play treasure animation
        anim.SetTrigger("Open Chest");
        //wait
        yield return new WaitForSeconds(1f);
        // Load Win Menu
        WinDisplay.SetActive(true);
        anim.SetTrigger("Stays Open");
    }
}

