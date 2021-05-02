using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyTile : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponentInParent<PlayerMovement>().stickyCount += 1;
        Debug.Log("Sticky: " + collision.gameObject.GetComponentInParent<PlayerMovement>().stickyCount);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        collision.gameObject.GetComponentInParent<PlayerMovement>().stickyCount -= 1;
        Debug.Log("Sticky: " + collision.gameObject.GetComponentInParent<PlayerMovement>().stickyCount);
    }
}
