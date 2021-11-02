using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    
    [SerializeField] public float bulletForce = 1f;
    [SerializeField] float bulletTime = 2.0f;
    float currentBulletTime;
    [SerializeField] public GameObject bulletPrefab;
    [SerializeField] GameObject player;
    public int gunType;
    // Start is called before the first frame update
    void Start()
    {
        gunType = 1;
        currentBulletTime = bulletTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);

        currentBulletTime -= Time.deltaTime;
        if (currentBulletTime < 0)
        {
            Shoot();
            currentBulletTime = bulletTime;
        }

    }

    void Shoot()
    {
        //Vector3 distanceVector = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //distanceVector = distanceVector.normalized;
        //Vector3 targetPosition = (distanceVector * 5.0f);
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * bulletForce, ForceMode2D.Impulse);

    }


}
