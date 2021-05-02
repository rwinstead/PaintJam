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

    public float standardMoveSpeed=3f;
    public float stickyMoveSpeed=1f;

    public int slippingCount = 0;
    public int stickyCount = 0;

    public bool canMove = true;

    void Update()
    {

        if (!canMove) return;

        if (slippingCount <= 0)
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

        if (slippingCount > 0)
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
        moveSpeed = standardMoveSpeed;
        if (stickyCount > 0) { moveSpeed = stickyMoveSpeed; }

        if (slippingCount <= 0 && canMove)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }

    public void Respawn()
    {
        rb.transform.position = respawnPosition.transform.position;
    }


}
