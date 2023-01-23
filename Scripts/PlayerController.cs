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
    private AudioSource footsteps;

    //private bool isGrounded = false;

    public Transform playerFeet;
    public LayerMask groundLayer;
    private Rigidbody2D playerRb;
    private Animator player_anim;

    // Start is called before the first frame update
    void Start()
    {
        //Get reference to rigidbody component for left right movement and jumping
        playerRb = GetComponent<Rigidbody2D>();
        player_anim = GetComponent<Animator>();
        footsteps = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get direction keypress from user
        direction_vertical = Input.GetAxis("Vertical");
        player_anim.SetFloat("speed_vert", Mathf.Abs(direction_vertical));

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
        player_anim.SetFloat("speed_hor", Mathf.Abs(direction_horizontal));

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

    }

    private void Steps()
    {
        footsteps.Play();
    }

}
