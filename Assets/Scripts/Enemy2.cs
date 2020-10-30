using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public int health = 100;

    public Transform player;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Animator anim;
    private bool hitbefore = false;
    public bool detectPC = false;
    private bool stabrange = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame

    void Update()
    {
        if (detectPC == true)
        {
            Vector3 direction = player.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg -90f;
            rb.rotation = angle;
            direction.Normalize();
            movement = direction;
        }
    }
    private void FixedUpdate()
    {
        if (detectPC == true)
        {
            moveCharacter(movement);
        }
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           // anim.SetBool("meleeRange", true);
            stabrange = true;
           // GetComponent<AudioSource>().Play();
            collision.gameObject.SendMessage("TakeDamage", 20);
            
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
       // anim.SetBool("meleeRange", false);
       // GetComponent<AudioSource>().Stop();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerController player = collision.GetComponent<playerController>();
        if (player != null)
        {
            Debug.Log("Vi kommer hit iaf");
            if (stabrange==true)
            {
              //  Debug.Log("Spelaren borde ta skada?");
              //  player.TakeDamage(20);
            }
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        if (hitbefore == false)
        {
            Data.Kills += 1;
            Destroy(gameObject);
            Debug.Log("antal kills är nu " + Data.Kills);
            hitbefore = true;
        }
    }
}