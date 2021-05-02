using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawners : MonoBehaviour
{

    public GameObject projectile;

    float fireRate = 5f;
    float currentTime;
    float nextShot;


    void OnDrawGizmos()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, .1f);
    }

    private void OnEnable()
    {
        currentTime = Time.time;
        nextShot = currentTime + 2f;
    }

    private void Update()
    {
       
        if(Time.time >= nextShot)
        {
            for (int i = 0; i < 5; i++)
            {
                var newProjectile = Instantiate(projectile, transform.position + transform.forward * 1, transform.rotation);
                nextShot = Time.time + fireRate;
            }
        }

    }
}
