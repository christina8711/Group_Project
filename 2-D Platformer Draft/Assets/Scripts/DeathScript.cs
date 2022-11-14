using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject Player;
    public HealthSystem playerHealth;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //When Player is collided with Game object(Enemy) Player position will teleport to startpoint
            Player.transform.position = startPoint.transform.position;
            //Player heart will be destroyed each time
            playerHealth.TakeDamage(1);
        }
    }
}
