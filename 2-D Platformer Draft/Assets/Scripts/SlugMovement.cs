using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlugMovement : MonoBehaviour
{
    public float speed;
    [SerializeField] private float movementDistance;
    private bool movingLeft;
    private float leftEdge;
    private float rightEdge;
   
    void Awake()
    {
        //Awake Allows variables to be initialized before application starts
        leftEdge = transform.position.x - movementDistance;
        rightEdge = transform.position.x + movementDistance;
    }

    // Update is called once per frame
    void Update()
    {
        //Allows game object to move back and fourth at a set distance and speed
        if (movingLeft)
        {
            if(transform.position.x > leftEdge)
            {
                transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
                transform.localScale = new Vector3((float)7.525488, (float)7.525488, (float)7.525488);
            }
            else
                movingLeft = false;
                
        }
        else
        {
            if (transform.position.x < rightEdge)
            {
                transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
                transform.localScale = new Vector3((float)-7.525488, (float)7.525488, (float)7.525488);
            }
            else
                movingLeft = true;
        }
    }
}
