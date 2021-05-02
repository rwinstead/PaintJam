using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerLives : MonoBehaviour
{

    public BattleModeManager battleManager;

    public int lives = 5;
    public TextMeshProUGUI LivesCountUI;

    private void OnEnable()
    {
        lives = 5;
    }

    public void TakeDamage(int dmg)
    {
        lives = lives - dmg;
        if(lives == 0)
        {
            battleManager.ResetBattle();
        }
    }
    
}
