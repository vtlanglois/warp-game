using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 50f;
    float horizontalInput, verticalInput;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, 0);
        Vector2 velocity = new Vector2(horizontalInput, verticalInput);
        rb.velocity += velocity * speed;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision!");
    }


}
