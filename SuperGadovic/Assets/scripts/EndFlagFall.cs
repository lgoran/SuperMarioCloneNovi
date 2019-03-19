using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndFlagFall : MonoBehaviour
{
    public GameObject player;
    public GameObject flag;
    public GameObject bottomFlagPoint;
    public BoxCollider2D flagwall;
    public float downSpeed = 0.05f;
    private int isdroping = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.GetComponent<CharacterController2D>().Move(0f, false, false);
            player.GetComponent<CharacterController2D>().enabled = false;
            player.GetComponent<PlayerMovement>().enabled = false;
            player.GetComponent<Rigidbody2D>().mass = 0;
            player.GetComponent<Rigidbody2D>().gravityScale = 0;
            isdroping = 1;
        }

    }
    void FixedUpdate()
    {
        if (isdroping == 1)
        {
            flag.transform.position = Vector3.MoveTowards(flag.transform.position, bottomFlagPoint.transform.position, downSpeed * Time.fixedDeltaTime);
            player.transform.position = Vector3.MoveTowards(player.transform.position, bottomFlagPoint.transform.position, downSpeed * Time.fixedDeltaTime);
            if (flag.transform.position == bottomFlagPoint.transform.position)
            {
                Destroy(flagwall);
                player.GetComponent<Rigidbody2D>().mass = 1;
                player.GetComponent<Rigidbody2D>().gravityScale = 5;
                player.GetComponent<CharacterController2D>().enabled = true;
                isdroping = 2;
            }
        }
        if (isdroping == 2)
        {
            player.GetComponent<CharacterController2D>().Move(1f, false, false);
            StartCoroutine(FinishLevel());
        }
    }
    IEnumerator FinishLevel()
    {
        yield return new WaitForSeconds(5f);
        player.GetComponent<PlayerMovement>().enabled = true;
        if (Map_class.prijedeni_leveli[SceneManager.GetActiveScene().buildIndex-1] == false)
            Map_class.PrijedenLevel(SceneManager.GetActiveScene().buildIndex);
        Map_class.povratak_u_scenu = 1;
        SceneManager.LoadScene(0);
    }
}
