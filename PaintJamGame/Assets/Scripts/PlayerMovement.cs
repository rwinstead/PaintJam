using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 1f;
    public Vector2 movement;
    public Rigidbody2D rb;

    public bool isSlipping = false;


    void Update()
    {
        if (!isSlipping)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }
    }

    private void FixedUpdate()
    {

        if (!isSlipping)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }

}
