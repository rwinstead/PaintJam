using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlipperyTile : MonoBehaviour
{

    private Vector2 slipMovement;

    private bool isSlipping;

    private PlayerMovement playerMovement;

    private Rigidbody2D playerRB;

    public float slipSpeed = 2f;

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        slipMovement = collision.gameObject.GetComponent<PlayerMovement>().movement;
        playerMovement = collision.gameObject.GetComponent<PlayerMovement>();
        playerMovement.isSlipping = true;
        playerRB = collision.attachedRigidbody;
        isSlipping = true;
    }

    private void FixedUpdate()
    {
        if(isSlipping)
        {
            playerRB.MovePosition(playerRB.position + slipMovement * slipSpeed * Time.fixedDeltaTime);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isSlipping = false;
        playerMovement.isSlipping = false;
    }

}
