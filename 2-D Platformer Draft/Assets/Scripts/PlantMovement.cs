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
        //Grabs references animator from object
        anim = GetComponent<Animator>();

    }
    //tracks if Player touches plant and will play animation and load death
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(PlantAttack());
        }
    }
    //IEnumerator will allow the animation to play before player dies and teleports back to start point
    IEnumerator PlantAttack()
    {
        // Play treasure animation
        anim.SetTrigger("Attack");
        //wait
        yield return new WaitForSeconds(1.7f);
        // Load player death
        Player.transform.position = startPoint.transform.position;
        playerHealth.TakeDamage(1);
    }
}
