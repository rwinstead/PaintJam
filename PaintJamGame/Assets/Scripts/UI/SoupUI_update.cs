using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SoupUI_update : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponentInParent<TextMeshProUGUI>().text = Player.GetComponent<PlayerCollectibles>().keyCount.ToString();
    }
}
