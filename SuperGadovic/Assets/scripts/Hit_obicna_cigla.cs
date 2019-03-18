﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_obicna_cigla : MonoBehaviour
{
    int health = 3;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            health--;
            gameObject.GetComponent<Animation>().Play();
        }
        if (health == 0)
            Destroy(gameObject);
    }

}