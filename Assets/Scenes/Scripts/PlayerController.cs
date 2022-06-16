using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 3f;
    public float playerFeetRadius = 0.2f;
    private float direction_horizontal = 0f;
    private float direction_vertical = 0f;
    //private bool isGrounded = false;

    public Transform playerFeet;
    public LayerMask groundLayer;
    private Rigidbody2D playerRb;

    // Start is called before the first frame update
    void Start()
    {
        //Get reference to rigidbody component for left right movement and jumping
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get direction keypress from user
        direction_vertical = Input.GetAxis("Vertical");

        //Move the player
        if (direction_vertical != 0)
        {
            playerRb.velocity = new Vector2(direction_vertical * speed, playerRb.velocity.y);
        }
        else
        {
            playerRb.velocity = new Vector2(0, playerRb.velocity.y);
        }

        direction_horizontal = Input.GetAxis("Horizontal");

        if (direction_horizontal != 0)
        {
            playerRb.velocity = new Vector2(direction_horizontal * speed, playerRb.velocity.x);
        }
        else
        {
            playerRb.velocity = new Vector2(0, playerRb.velocity.x);
        }

        //Character to face correct direction
        if (direction_horizontal > 0) //moving right
        {
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
        }
        else if (direction_horizontal < 0) //moving left
        {
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
        }

        //    //Check if player is grounded
        //    isGrounded = Physics2D.OverlapCircle(playerFeet.position, playerFeetRadius, groundLayer);

        //    //Handle player jumping, player jumps when jump key is pressed and its not midair
        //    if (Input.GetButtonDown("Jump") && isGrounded)
        //    {
        //        playerRb.velocity = new Vector2(playerRb.velocity.x, jumpForce);
        //    }
    }
}
