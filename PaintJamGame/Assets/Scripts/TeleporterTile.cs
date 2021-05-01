using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterTile : MonoBehaviour
{
    [SerializeField]
    private GameObject pairedTeleporter;

    public bool justTeleported;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!justTeleported)
        {
            collision.attachedRigidbody.position = pairedTeleporter.transform.position;
        }
        justTeleported = true;
        pairedTeleporter.GetComponent<TeleporterTile>().justTeleported = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        justTeleported = false;
    }

}
