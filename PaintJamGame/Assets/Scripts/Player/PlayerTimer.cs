using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTimer : MonoBehaviour
{
    public float LevelTime = 120;
    public float TimeRemaining;

    void Start()
    {
        TimeRemaining = LevelTime;
    }

    void Update()
    {

        TimeRemaining -= Time.deltaTime;

    }




}
