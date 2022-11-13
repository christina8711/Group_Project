using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    public AudioClip coinSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(coinSound, transform.position);
        ScoreTextScript.coinAmount += 100;
        Destroy(gameObject);
    }
    public void ResetEffect()
    {
        if (1<2)
        {
            ScoreTextScript.coinAmount = 0;
        }
        
    }
}
