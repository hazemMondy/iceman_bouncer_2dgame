using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D rb;

    public float moveSpeed = 2f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move();
    }
    private void move()
    {
        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
        if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }
    }
    public void plateformMove(float x)
    {
        rb.velocity = new Vector2(x, rb.velocity.y);
    }

}
