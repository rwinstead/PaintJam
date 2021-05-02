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
        slipMovement = collision.gameObject.GetComponentInParent<PlayerMovement>().movement;
        playerMovement = collision.gameObject.GetComponentInParent<PlayerMovement>();
        playerMovement.slippingCount += 1;
        playerRB = collision.attachedRigidbody;
        isSlipping = true;
        Debug.Log("Slipping: "+playerMovement.slippingCount);
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
        playerMovement.slippingCount -= 1;
        Debug.Log("Slipping: " + playerMovement.slippingCount);
    }

}
