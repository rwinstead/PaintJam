using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTimer : MonoBehaviour
{
    public float LevelTime = 30;
    public float TimeRemaining;

    public bool startTime = false;

    void Start()
    {
        TimeRemaining = LevelTime;
    }

    private void OnEnable()
    {
        TimeRemaining = 30;
    }

    void Update()
    {
        if (startTime)
        {
            TimeRemaining -= Time.deltaTime;
        }

    }




}
