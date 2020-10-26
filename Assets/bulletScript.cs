using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public Transform invisibleGun;
    public GameObject bulletPrefab;

    public float bulletForce =20f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, invisibleGun.position, invisibleGun.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(invisibleGun.up * bulletForce, ForceMode2D.Impulse);

    }
}
