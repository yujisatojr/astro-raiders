using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRB;
    public GameObject bullet;
    public float moveSpeed = 5.0f;
    private Vector2 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Keep the player in bounds
        if (transform.position.x > 7)
        {
            transform.position = new Vector2(7, transform.position.y);
        }
        if (transform.position.x < -7)
        {
            transform.position = new Vector2(-7, transform.position.y);
        }
        if (transform.position.y > 13)
        {
            transform.position = new Vector2(transform.position.x, 13);
        }
        if (transform.position.y < 7)
        {
            transform.position = new Vector2(transform.position.x, 7);
        }

        ProcessInputs();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, bullet.transform.rotation);
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        playerRB.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
