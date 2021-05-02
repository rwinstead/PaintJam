using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{

    public float speed = 2f;

    public float slope = 0f;

    private void OnEnable()
    {
        slope = Random.Range(-.005f, .005f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(slope,  speed * Time.deltaTime, 0);
    }
}
