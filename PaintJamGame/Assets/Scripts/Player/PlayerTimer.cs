using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerTimer : MonoBehaviour
{
    public float LevelTime = 30;
    public float TimeRemaining;

    public bool startTime = false;

    public string nextLevel;

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

        if (TimeRemaining <= 0)
        {
            SceneManager.LoadScene(nextLevel, LoadSceneMode.Single);
        }

    }




}
