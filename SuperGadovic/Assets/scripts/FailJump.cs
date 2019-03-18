using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailJump : MonoBehaviour
{
    public GameObject player;
    public CharacterController2D controller;
    private int jumped = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            player.GetComponent<PlayerMovement>().enabled = false;
            if(jumped==0)
            StartCoroutine(WaitForJump());
        }
    }
    IEnumerator WaitForJump()
    {
        jumped = 1;
        yield return new WaitForSeconds(3f);
        controller.Move(0f, false, true);
        yield return new WaitForSeconds(2f);
        player.transform.position = new Vector3(0, 0, 0);
        player.GetComponent<PlayerMovement>().enabled = true;
        LifeCount.lifeCount--;
        jumped = 0;
    }
}
