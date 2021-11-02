using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    float gracePeriod = 0.5f;
    float currentTime = 0;
    bool lethal = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (currentTime >= gracePeriod)
        {
            Physics2D.IgnoreLayerCollision(6, 7, false);
            Debug.Log("time!");
        } else
        {
            currentTime += Time.deltaTime;
        }
        */
        
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player" )
        {
            Destroy(gameObject);
            Debug.Log("player!");
        }
        
    }
}
