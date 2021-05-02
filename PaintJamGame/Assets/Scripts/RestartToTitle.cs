using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartToTitle : MonoBehaviour
{


    public void loadTitle()
    {
        SceneManager.LoadScene("Intro", LoadSceneMode.Single);
    }

}
