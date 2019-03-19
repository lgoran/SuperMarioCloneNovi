using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ulazak_Leveli : MonoBehaviour
{
    public Transform player;
    public Transform[] leveli_pozicije = new Transform[4];
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            for(int i=0;i<leveli_pozicije.Length;i++)
            {
                if(leveli_pozicije[i].position==player.position)
                {
                    Map_movement.mario_pos = player.position;
                    SceneManager.LoadScene(i + 1);
                }
            }
        }
    }
}
