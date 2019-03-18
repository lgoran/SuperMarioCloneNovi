using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStopOnTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject cam
        ;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            cam.GetComponent<CameraFollow>().enabled = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            cam.GetComponent<CameraFollow>().enabled = true;
        }
    }
}
