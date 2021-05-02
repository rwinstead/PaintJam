using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsBtn : MonoBehaviour
{

    public GameObject camera;

    public void moveCameraControls()
    {
        camera.transform.position = new Vector3(23, 0, -10);
    }

    public void moveCameraCredits()
    {
        camera.transform.position = new Vector3(23, -12.15f, -10);
    }

}
