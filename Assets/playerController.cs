using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed;

    Rigidbody2D rb2d;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, y, 0);
        if (movement.sqrMagnitude > 1)
            movement = movement.normalized;

    

        rb2d.velocity = movement * speed;

        anim.SetFloat("Movement.X", rb2d.velocity.x);
        anim.SetFloat("Movement.Y", rb2d.velocity.y);
        if (rb2d.velocity.x == 0 && rb2d.velocity.y == 0)
        {
            anim.SetBool("noInput", true);
        }
        else
            anim.SetBool("noInput", false);

       
    }
}

