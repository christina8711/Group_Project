using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public AudioClip coinSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreTextScript.coinAmount += 100;
        AudioSource.PlayClipAtPoint(coinSound, transform.position);
        Destroy(gameObject);
    }
}
