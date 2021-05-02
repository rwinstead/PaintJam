using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTile : MonoBehaviour
{
    public BattleModeManager battleManager;

    private bool inGoal = false;

    private void Start()
    {
        battleManager = GameObject.FindGameObjectWithTag("BattleManager").GetComponent<BattleModeManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            if(collision.gameObject.GetComponent<PlayerCollectibles>().keyCount == 4 && !inGoal)
            {
                inGoal = true;
                FindObjectOfType<AudioManager>().Play("BossTeleport");
                battleManager.battleStart = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inGoal = false;
    }

}
