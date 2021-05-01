using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerLives : MonoBehaviour
{

    public int lives = 5;
    public TextMeshProUGUI LivesCountUI;

    public void TakeDamage(int dmg)
    {
        lives = lives - dmg;
    }
    
}
