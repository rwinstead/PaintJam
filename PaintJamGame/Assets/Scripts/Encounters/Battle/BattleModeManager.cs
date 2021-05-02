using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleModeManager : MonoBehaviour
{

    public GameObject main;

    public GameObject battleCam;

    public GameObject projectileSpawners;

    public GameObject player;

    public GameObject dieCanvas;

    public GameObject livesCanvas;

    public GameObject timeCanvas;

    public PlayerTimer playertime;

    public bool battleStart = false;

    public GameObject playerHead;


    void Start()
    {
        main.SetActive(true);
        battleCam.SetActive(false);
    }

    void Update()
    {
        
        if(battleStart)
        {
            main.SetActive(false);
            battleCam.SetActive(true);
            projectileSpawners.SetActive(true);
            player.GetComponent<PlayerMovement>().canMove = false;
            dieCanvas.SetActive(true);
            livesCanvas.SetActive(true);
            timeCanvas.SetActive(true);
            playertime.startTime = true;
            playerHead.SetActive(true);
        }

        else
        {
            main.SetActive(true);
            battleCam.SetActive(false);
            projectileSpawners.SetActive(false);
            player.GetComponent<PlayerMovement>().canMove = true;
            dieCanvas.SetActive(false);
            livesCanvas.SetActive(false);
            timeCanvas.SetActive(false);
            playertime.startTime = false;
            playerHead.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
           // battleStart = !battleStart;
        }

    }

    public void ResetBattle()
    {
        battleStart = !battleStart;
    }

}
