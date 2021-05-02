using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollectibles : MonoBehaviour
{
    public int keyCount = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.tag == "Collectible")
        {
            Debug.Log("Got Soup");
            keyCount++;
            Destroy(collision.gameObject);
            FindObjectOfType<AudioManager>().Play("SoupPickup");
            Debug.Log("Soup Count: " + keyCount);
        }
    }
}
