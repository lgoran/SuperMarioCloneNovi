using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Camera cam;
    public GameObject player;

    void FixedUpdate()
    {
        cam.transform.position = new Vector3(player.transform.position.x, cam.transform.position.y, cam.transform.position.z);
    }
}
