using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    
    public float bulletForce = 200f;
    [SerializeField] public GameObject bulletPrefab;
    public int gunType;
    // Start is called before the first frame update
    void Start()
    {
        gunType = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        switch(gunType)
        {
            case 1:
                GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.up * bulletForce, ForceMode2D.Impulse);
                break;
            case 2:
                GameObject speedyBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                Rigidbody2D speedyBullet_rb = speedyBullet.GetComponent<Rigidbody2D>();
                speedyBullet_rb.AddForce(transform.up * (bulletForce+100f), ForceMode2D.Impulse);
                break;
        }
        
        /*GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * bulletForce, ForceMode2D.Impulse);*/
    }


}
