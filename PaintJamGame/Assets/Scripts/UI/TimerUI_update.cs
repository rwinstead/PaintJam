using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimerUI_update : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        GetComponentInParent<TextMeshProUGUI>().text = Player.GetComponent<PlayerTimer>().TimeRemaining.ToString();
    }
}
