using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player" )
        {
            SceneManager.LoadScene("lvl_1", LoadSceneMode.Single);
            Debug.Log("player!");
        }
        
    }
}
