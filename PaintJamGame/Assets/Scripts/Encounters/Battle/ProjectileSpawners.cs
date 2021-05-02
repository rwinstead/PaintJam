using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawners : MonoBehaviour
{

    public GameObject projectile;

    float fireRate = 2f;
    float currentTime;
    float nextShot;
    public string projectileDirection;

    public int projectileCount = 3;

    public float bananaSpeedMax = 2f;


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
            for (int i = 0; i < projectileCount; i++)
            {
                var newProjectile = Instantiate(projectile, transform.position + transform.forward * 1, transform.rotation);
                newProjectile.GetComponent<ProjectileMove>().myDirection = projectileDirection;
                newProjectile.GetComponent<ProjectileMove>().maxSpeed = bananaSpeedMax;
                nextShot = Time.time + fireRate;
            }
        }

    }
}
