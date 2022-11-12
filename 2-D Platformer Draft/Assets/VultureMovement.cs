using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VultureMovement : MonoBehaviour
{

    public Vector3 posA;
    public Vector3 PosB;
    public float speed = 1.0f;
    private Animator anim;
    private bool currentlyColliding;
    public Transform iniPos;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        transform.position = new Vector3 ((float)228.36,(float)1.75, 0);

}

    //tracks if Player touches pole, vulture will fly away
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            currentlyColliding = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            currentlyColliding = false;
        }
    }
    // Update is called once per frame
    // Lets you input posA vertices and PosB Vertices
    // IF YOU ARE using this code on a tilemap platform make sure platform is placed in center of tile map position(0,0)
    void Update()
    {
        if (currentlyColliding)
        {
            anim.SetTrigger("Fly");
            transform.position = Vector3.Lerp(posA, PosB, Mathf.PingPong(Time.time * speed, 1.0f));
        }
        else
        {
            anim.ResetTrigger("Fly");
            transform.position = new Vector3((float)228.36, (float)1.75, 0);
        }

        

    }
}


