using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private bool move;

    public float jump;
    public bool isJumping;

    private Rigidbody2D rb;
    private Animator anim;

    public float fallHeight;
    public HealthSystem playerHealth;
    public GameObject startPoint;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        //Grabs references for rigbody and animator from object
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * move, rb.velocity.y);
        //Flip player moving left-right
        if (move > 0.01f)
        {
            transform.localScale = new Vector3((float)0.2462711,(float) 0.2462711,(float) 0.2462711);
        }
        else if (move < -0.01f)
        {
            transform.localScale = new Vector3((float)-0.2462711, (float)0.2462711,(float) 0.2462711);
        }
        // Sets running parameters
        anim.SetBool("Run", move != 0);


        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x,jump));
            Debug.Log("jump");
            fallHeight = this.transform.position.y;
        }
        //Sets Jumping Parameters
        anim.SetBool("Grounded", isJumping == true);
        anim.SetTrigger("Jump");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;

            //Checks For Fall Damage
            if (fallHeight <= 0 && this.transform.position.y < -10f)
            {
                Debug.Log("Took Fall Damage");
                Player.transform.position = startPoint.transform.position;
                playerHealth.TakeDamage(1);
            }
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }

    
}
