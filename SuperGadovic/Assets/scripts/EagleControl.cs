using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleControl : MonoBehaviour
{
    public GameObject eagle;
    public float runspeed = 2f;
    public Transform upTrigger;
    public Transform downTrigger;
    private void Start()
    {
        transform.position = upTrigger.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Eagle"))
        {
            if (transform.position == upTrigger.position)
            {
                transform.position = downTrigger.position;
            }
            else if (transform.position == downTrigger.position)
            {
                transform.position = upTrigger.position;
            }
        }
    }
    private void FixedUpdate()
    {
        eagle.transform.position = Vector3.MoveTowards(eagle.transform.position, transform.position, runspeed * Time.fixedDeltaTime);
    }
}
