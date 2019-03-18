using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpossumControl : MonoBehaviour
{
    public GameObject opossum;
    public float runspeed=2f;
    public Transform leftTrigger;
    public Transform rightTrigger;
    private void Start()
    {
        transform.position = leftTrigger.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Opossum"))
        {
            if (transform.position == leftTrigger.position)
            {
                transform.position = rightTrigger.position;
                opossum.transform.Rotate(new Vector3(0, 180f, 0));
            }
            else if (transform.position == rightTrigger.position)
            {
                transform.position = leftTrigger.position;
                opossum.transform.Rotate(new Vector3(0, 180f, 0));
            }
        }
    }
    private void FixedUpdate()
    {
        opossum.transform.position = Vector3.MoveTowards(opossum.transform.position, transform.position, runspeed * Time.fixedDeltaTime);
    }
}
