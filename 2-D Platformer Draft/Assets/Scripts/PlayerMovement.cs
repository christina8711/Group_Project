using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private bool move;

    public float jump;
    public bool notGrounded;

    private Rigidbody2D rb;
    private Animator anim;

    public float fallHeight;
    public HealthSystem playerHealth;
    public GameObject startPoint;
    public GameObject Player;
    private Collider2D _Collider;

    // Start is called before the first frame update
    void Start()
    {
        //Grabs references for rigbody, animator, and Collider from object
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        _Collider = GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {   //Lets Player Run
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
        // Sets running parameters for animation
        if (move != 0)
        {
            anim.SetBool("Run", true);
            anim.SetTrigger("Run");
        }
        if (move == 0)
        {
            anim.SetBool("Run", false);
            anim.ResetTrigger("Run");
        }
        //Lets Player Jump
        if (Input.GetButtonDown("Jump") && notGrounded == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x,jump));
            Debug.Log("jump");
            fallHeight = this.transform.position.y;
        }
        //Sets Jumping Parameters
        if (Input.GetButtonDown("Jump"))
        {
            anim.SetBool("Grounded", true);
                anim.SetTrigger("Jump");
        }
        if (Input.GetButtonUp("Jump"))
        {
            anim.SetBool("Grounded", false);
            anim.ResetTrigger("Jump");
        }


    }
    //Prevents Double Jumping when Player is not on ground
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            notGrounded = false;

            //Checks For Fall Damage
            if (fallHeight <= 0 && this.transform.position.y < -10f)
            {
                Debug.Log("Took Fall Damage");
                Player.transform.position = startPoint.transform.position;
                playerHealth.TakeDamage(1);
            }
        }
        //when player is on a moving platform the player will become a child of the platform only if the player is on it
        if (other.gameObject.CompareTag("Mground"))
        {
            this.transform.parent = other.transform;
            notGrounded = false;
        }
        //Working on fixing double jump on moving platforms
        if (this.transform.parent == other.transform && Input.GetAxisRaw("Vertical") < 0)
        {
            _Collider.enabled = true;
            StartCoroutine(EnableCollider());
        }

    }
    private IEnumerator EnableCollider()
    {
        yield return new WaitForSeconds(.5f);
        _Collider.enabled = false;
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            notGrounded = true;
        }
        //when player jumps off moving platform
        if (other.gameObject.CompareTag("Mground"))
        {
            this.transform.parent = null;
            notGrounded = true;
        }
    }
}
