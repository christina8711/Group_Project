using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject Player;
    public HealthSystem playerHealth;
    // Start is called before the first frame update
    void start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player.transform.position = startPoint.transform.position;
            playerHealth.TakeDamage(1);
        }
    }
}
