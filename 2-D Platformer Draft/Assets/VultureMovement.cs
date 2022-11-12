using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VultureMovement : MonoBehaviour
{


    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();


}

    //tracks if Player touches pole, vulture will fly away
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetTrigger("Fly");
        }
    }

    // Update is called once per frame
    // Lets you input posA vertices and PosB Vertices
    // IF YOU ARE using this code on a tilemap platform make sure platform is placed in center of tile map position(0,0)
    void Update()
    {
        

    }
}


