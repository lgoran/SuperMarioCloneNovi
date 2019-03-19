using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_movement : MonoBehaviour
{
    public Transform player;
    public GameObject pozicije_parent;
    public static Vector3 mario_pos;
    public float speed = 5f;
    private static Transform[] pozicije = new Transform[100];
    private static int brojDjece;
    void Awake()
    {
        brojDjece = pozicije_parent.transform.childCount;
        for (int i = 0; i < brojDjece; i++)
        {
            if (i <= 9)
                pozicije[i] = pozicije_parent.transform.Find("pozicija0" + i.ToString());
            else
                pozicije[i] = pozicije_parent.transform.Find("pozicija" + i.ToString());
        }
    }
    void Update()
    {
        if (Map_class.povratak_u_scenu == 1)
        {
            player.position = mario_pos;
            Map_class.povratak_u_scenu = 0;
        }
        if (Input.GetButtonDown("up") && Map_class.polje[Map_class.currPos][0] != -1 && player.position == pozicije[Map_class.currPos].position && Map_class.pom == -1)
        {
            Map_class.pom = 0;
        }
        else if (Input.GetButtonDown("right") && Map_class.polje[Map_class.currPos][1] != -1 && player.position == pozicije[Map_class.currPos].position && Map_class.pom == -1)
        {
            Map_class.pom = 1;
        }
        else if (Input.GetButtonDown("down") && Map_class.polje[Map_class.currPos][2] != -1 && player.position == pozicije[Map_class.currPos].position && Map_class.pom == -1)
        {
            Map_class.pom = 2;
        }
        else if (Input.GetButtonDown("left") && Map_class.polje[Map_class.currPos][3] != -1 && player.position == pozicije[Map_class.currPos].position && Map_class.pom == -1)
        {
            Map_class.pom = 3;
        }

        if (Map_class.pom == 0)
        {
            player.position = Vector3.MoveTowards(player.position, pozicije[Map_class.polje[Map_class.currPos][0]].position, speed * Time.fixedDeltaTime);
            if (player.position == pozicije[Map_class.polje[Map_class.currPos][0]].position)
            {
                Map_class.currPos = Map_class.polje[Map_class.currPos][0];
                Map_class.pom = -1;
            }
        }
        else if (Map_class.pom == 1)
        {
            player.position = Vector3.MoveTowards(player.position, pozicije[Map_class.polje[Map_class.currPos][1]].position, speed * Time.fixedDeltaTime);
            if (player.position == pozicije[Map_class.polje[Map_class.currPos][1]].position)
            {
                Map_class.currPos = Map_class.polje[Map_class.currPos][1];
                Map_class.pom = -1;
            }
        }
        else if (Map_class.pom == 2)
        {
            player.position = Vector3.MoveTowards(player.position, pozicije[Map_class.polje[Map_class.currPos][2]].position, speed * Time.fixedDeltaTime);
            if (player.position == pozicije[Map_class.polje[Map_class.currPos][2]].position)
            {
                Map_class.currPos = Map_class.polje[Map_class.currPos][2];
                Map_class.pom = -1;
            }

        }
        else if (Map_class.pom == 3)
        {
            player.position = Vector3.MoveTowards(player.position, pozicije[Map_class.polje[Map_class.currPos][3]].position, speed * Time.fixedDeltaTime);
            if (player.position == pozicije[Map_class.polje[Map_class.currPos][3]].position)
            {
                Map_class.currPos = Map_class.polje[Map_class.currPos][3];
                Map_class.pom = -1;
            }
        }
    }

}