using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            CoinCounter.brojac++;
            gameObject.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(deletecoin());
        }
    }
    IEnumerator deletecoin()
    {
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }
}
