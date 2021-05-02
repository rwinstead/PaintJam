using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 1f;
    public Vector2 movement;
    public Rigidbody2D rb;
    public GameObject respawnPosition;

    public Animator anim;

    public bool isSlipping = false;


    void Update()
    {
        if (!isSlipping)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }

        if (Mathf.Abs(movement.x) + Mathf.Abs(movement.y) > 0)
        {
            anim.SetBool("IsMoving", true);
        }
        else
        {
            anim.SetBool("IsMoving", false);
        }

        if(movement.x > 0)
        {
            anim.SetBool("WalkingRight", true);
        }
        else
        {
            anim.SetBool("WalkingRight", false);
        }

        if (movement.x < 0)
        {
            anim.SetBool("WalkingLeft", true);
        }
        else
        {
            anim.SetBool("WalkingLeft", false);
        }

        if(isSlipping)
        {
            anim.SetBool("IsSliding", true);
        }
        else
        {
            anim.SetBool("IsSliding", false);
        }


    }

    private void FixedUpdate()
    {

        if (!isSlipping)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }

    public void Respawn()
    {
        rb.transform.position = respawnPosition.transform.position;
    }


}
