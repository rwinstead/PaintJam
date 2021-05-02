using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("Death");
            collision.gameObject.GetComponent<PlayerLives>().TakeDamage(1);
            collision.gameObject.GetComponent<PlayerMovement>().Respawn();
        }
    }
}
