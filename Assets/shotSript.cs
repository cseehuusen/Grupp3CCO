using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotSript : MonoBehaviour
{

    public Camera cam;
    Rigidbody2D rb2d;

    Vector2 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(-.21f, -0.087f, 0);
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    private void FixedUpdate()
    {
        Vector2 shotDir = mousePos - rb2d.position;
        float angle = Mathf.Atan2(shotDir.y, shotDir.x) * Mathf.Rad2Deg - 90f;
        rb2d.rotation = angle;
    }
}
