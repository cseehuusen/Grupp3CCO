using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public Transform player;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

        private void OnCollisionEnter2D(Collision2D collision)
        {
         anim.SetBool("meleeRange", true);     
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
         anim.SetBool("meleeRange", false);
        }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerController player = collision.GetComponent<playerController>();
        if (player != null)
        {
            player.TakeDamage(5);
        }
    }
        public void TakeDamage (int damage)
         {
            health -= damage;

            if (health <=0)
            {
                Die();
            }

         }
    void Die()
    {
        Data.Kills +=1;
        Destroy(gameObject);
        Debug.Log("antal kills är nu " + Data.Kills);
    }
}