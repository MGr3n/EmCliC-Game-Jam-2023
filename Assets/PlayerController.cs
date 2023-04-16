using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    private float moveInput;

    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

     public int points = 0;

    void Start()
    {
    rb = GetComponent<Rigidbody2D>();

        
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if(isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
     private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Trash"))
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                points += 1;
               
                Destroy(other.gameObject);
            }
        }
    }
}
