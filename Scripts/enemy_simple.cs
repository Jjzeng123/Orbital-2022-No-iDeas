using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_simple : MonoBehaviour
{
    private float dirX;
    private float speed;
    private Rigidbody2D rb;
    private bool facingRight = false;
    private Vector3 localScale;
        
    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        dirX = -1f;
        speed = 4f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.CompareTag("wall")) || (collision.gameObject.CompareTag("Player")))
        {
            dirX *= -1f;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX * speed, rb.velocity.y);

    }

    void LateUpdate()
    {
        CheckWhereToFace();
    }

    void CheckWhereToFace()
    {
        if (dirX > 0)
        {
            facingRight = true;
        }
        else if (dirX < 0)
        {
            facingRight = false;
        }

        if (((facingRight) && (localScale.x < 0)) ||((!facingRight) && (localScale.x > 0)))
        {
            localScale.x *= -1;
        }

        transform.localScale = localScale;
    }
}
