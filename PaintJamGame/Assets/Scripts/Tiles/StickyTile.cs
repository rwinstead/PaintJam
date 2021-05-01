using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyTile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<PlayerMovement>().moveSpeed = 1;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<PlayerMovement>().moveSpeed = 5;
    }
}
