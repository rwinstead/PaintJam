using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayTile : MonoBehaviour
{

    public GameObject BlockWayBack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("oneway enter");
        BlockWayBack.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("oneway exit");
        BlockWayBack.SetActive(true);
    }
}
