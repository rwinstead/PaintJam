using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimerUI_update : MonoBehaviour
{
    int seconds;

    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        seconds = Mathf.RoundToInt(Player.GetComponent<PlayerTimer>().TimeRemaining);
        GetComponentInParent<TextMeshProUGUI>().text = seconds.ToString();
    }
}
