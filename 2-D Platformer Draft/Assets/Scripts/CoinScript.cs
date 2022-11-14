using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    //When Coin is collided with it will be destroyed and each coin destroyed will add 100 to the Score
    public AudioClip coinSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(coinSound, transform.position);
        ScoreTextScript.coinAmount += 100;
        Destroy(gameObject);
    }
    //This is will be referenced with other scripts when coin score will need to be reset
    public void ResetEffect()
    {
        if (1<2)
        {
            ScoreTextScript.coinAmount = 0;
        }
        
    }
}
