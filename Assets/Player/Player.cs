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
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
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
