using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    float horizontalInput, verticalInput, teleportDistance;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        teleportDistance = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        if(Input.GetKey(KeyCode.Return))
        {
            StartCoroutine(Teleport());
        }

    }

    private void FixedUpdate()
    {
        Vector2 velocity = new Vector2(horizontalInput, verticalInput);
        //velocity = velocity.normalized * speed * Time.deltaTime;
        rb.velocity = velocity * speed;
    }

    private IEnumerator Teleport()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + teleportDistance);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - teleportDistance);
        }

        yield return null;
    }


}
