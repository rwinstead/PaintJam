using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleModeManager : MonoBehaviour
{

    public GameObject main;

    public GameObject battleCam;

    public bool battleStart = false;

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
        }

        else
        {
            main.SetActive(true);
            battleCam.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            battleStart = !battleStart;
        }


    }
}
