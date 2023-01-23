using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class enemy_flee : MonoBehaviour
{
    private GameObject player;
    private Transform playerPos;
    private Vector2 currentPos;
    public float dist;
    public float speed;
    private GameObject questionmenu;
    // private bool facingRight = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        questionmenu = this.gameObject.transform.GetChild(0).gameObject;
        playerPos = player.GetComponent<Transform>();
        currentPos = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, playerPos.position) < dist)
        {
            checkfacingdir();
            // Vector2 tempvec = Vector2.MoveTowards(transform.position, -playerPos.position, speed * Time.deltaTime);
            // transform.position = new Vector3(tempvec.x, tempvec.y, transform.position.z) ;
            Vector3 dirToPlayer = transform.position - playerPos.position;
            Vector3 newPos = transform.position + dirToPlayer;
            Vector2 tempvec = Vector2.MoveTowards(transform.position, newPos, speed * Time.deltaTime);
            transform.position = new Vector3(tempvec.x, tempvec.y, transform.position.z);

        }
        else
        {
            if (Vector2.Distance(transform.position, currentPos) <= 0)
            {

            }
            else
            {
                Vector2 tempvec = Vector2.MoveTowards(transform.position, currentPos, speed * Time.deltaTime);
                transform.position = new Vector3(tempvec.x, tempvec.y, transform.position.z);
                checkfacingdirback();
            }
        }
    }


    void checkfacingdir()
    {
        Vector3 scale = transform.localScale;
        if (playerPos.position.x > transform.position.x)
        {
            scale.x = Mathf.Abs(scale.x);
        }
        else
        {
            scale.x = Mathf.Abs(scale.x) * -1;
        }
        transform.localScale = scale;
    }


    void checkfacingdirback()
    {
        Vector3 scale = transform.localScale;
        if (currentPos.x > transform.position.x)
        {
            scale.x = Mathf.Abs(scale.x);
        }
        else
        {
            scale.x = Mathf.Abs(scale.x) * -1;
        }
        transform.localScale = scale;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            questionmenu.SetActive(true);
        }
    }

}
