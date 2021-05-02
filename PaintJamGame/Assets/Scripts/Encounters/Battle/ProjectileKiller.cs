using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileKiller : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("proj killer collided");
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Destroy(collision.gameObject);
        }

    }

}
