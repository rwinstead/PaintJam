using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{

    public int lives = 5;

    public void TakeDamage(int dmg)
    {
        lives = lives - dmg;
    }
    
}
