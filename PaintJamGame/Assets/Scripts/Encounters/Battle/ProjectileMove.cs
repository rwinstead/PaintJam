using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{

    public float speed = 2f;

    public float slope = 0f;

    public string myDirection;

    public BattleModeManager battleManager;

    private void OnEnable()
    {
        battleManager = GameObject.FindGameObjectWithTag("BattleManager").GetComponent<BattleModeManager>();
        slope = Random.Range(-1f, 1f);
        speed = Random.Range(1f, 4f);
    }

    private void OnDisable()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

        if(battleManager.battleStart == false)
        {
            gameObject.SetActive(false);
        }

        else
        {
            gameObject.SetActive(true);
        }



        if (myDirection == "Up")
        {
            transform.Translate(slope * Time.deltaTime, speed * Time.deltaTime, 0);
        }

        if (myDirection == "Right")
        {
            transform.Translate(speed * Time.deltaTime, slope * Time.deltaTime, 0);
        }

        if (myDirection == "Down")
        {
            transform.Translate(slope * Time.deltaTime, -speed * Time.deltaTime, 0);
        }

        if (myDirection == "Left")
        {
            transform.Translate(-speed * Time.deltaTime, slope * Time.deltaTime, 0);
        }

    }
}
