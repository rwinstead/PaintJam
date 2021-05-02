using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleMovement : MonoBehaviour
{

    public float moveSpeed = 2f;
    public Vector2 movement;
    public Rigidbody2D rb;

    public bool encounterActive = false;

    public BattleModeManager battleManager;


    void Update()
    {
        encounterActive = battleManager.battleStart;

        if (encounterActive)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }
    }


    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

}
