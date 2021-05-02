using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleDmgDetect : MonoBehaviour
{

    public PlayerLives playerLives;
    public Animator anim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            anim.SetTrigger("TookDmg");
            playerLives.TakeDamage(1);
            Destroy(collision.gameObject);
        }
    }

}
