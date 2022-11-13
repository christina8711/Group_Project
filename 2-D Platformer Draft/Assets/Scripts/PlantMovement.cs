using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantMovement : MonoBehaviour
{
    public GameObject Player;
    public HealthSystem playerHealth;
    private Animator anim;
    public GameObject startPoint;
    private void Start()
    {
        anim = GetComponent<Animator>();

    }
    //tracks if Player touches treasure and will move to next level
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(WinMenu());
        }
    }
    IEnumerator WinMenu()
    {
        // Play treasure animation
        anim.SetTrigger("Attack");
        //wait
        yield return new WaitForSeconds(1.7f);
        // Load Win Menu
        Player.transform.position = startPoint.transform.position;
        playerHealth.TakeDamage(1);
    }
}
