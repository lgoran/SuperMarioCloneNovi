using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_movement : MonoBehaviour
{
    public Transform player;
    public int[][] polje = new int[100][];
    public GameObject pozicije_parent;
    public float speed = 5f;
    private Transform[] pozicije = new Transform[100];
    private static int currPos=0;
    private int brojDjece;
    private int i, pom=-1;
    void Awake()
    {
        for (i = 0; i < 100; i++) 
            polje[i] = new int[] {-1,-1,-1,-1};
        //INICIJALIZACIJA gore-0, desno-1, dolje-2, lijevo-3
        polje[0][2]=1;
        polje[1][0]=0;  polje[1][1]=2;  polje[1][3]=3;
        polje[2][3]=1;
        polje[3][3]=4;  polje[3][1]=1;
        polje[4][0]=5;  polje[4][1]=3;
        polje[5][0] = 6;    polje[5][2] = 4;
        polje[6][1] = 7;    polje[6][2] = 5;
        polje[7][0] = 9;    polje[7][1] = 8;    polje[7][3] = 6;
        polje[8][3] = 7;
        polje[9][2] = 7;    polje[9][3] = 10;
        polje[10][1] = 9;   polje[10][3] = 11;
        polje[11][0] = 12;  polje[11][1] = 10;
        polje[12][1] = 13;  polje[12][2] = 11;
        polje[13][1] = 14;  polje[13][3] = 12;
        polje[14][2] = 15;  polje[14][3] = 13;
        polje[15][0] = 14;  polje[15][1] = 16;
        polje[16][2] = 17;  polje[16][3] = 15;
        polje[17][0] = 16;
    }

    private void Start()
    {
        
        brojDjece = pozicije_parent.transform.childCount;
        for(i=0;i<brojDjece;i++)
        {
            if (i <= 9)
                pozicije[i] = pozicije_parent.transform.Find("pozicija0" + i.ToString());
            else
                pozicije[i] = pozicije_parent.transform.Find("pozicija" + i.ToString());

        }
        player.position = pozicije[0].position;
    }
    void Update()
    {
        if (Input.GetButtonDown("up") && polje[currPos][0] != -1 && player.position == pozicije[currPos].position && pom==-1)
        {
            pom = 0;
        }
        else if (Input.GetButtonDown("right") && polje[currPos][1] != -1 && player.position == pozicije[currPos].position && pom == -1)
        {
            pom = 1;
        }
        else if (Input.GetButtonDown("down") && polje[currPos][2] != -1 && player.position == pozicije[currPos].position && pom == -1)
        {
            pom = 2;
        }
        else if (Input.GetButtonDown("left") && polje[currPos][3] != -1 && player.position == pozicije[currPos].position && pom == -1)
        {
            pom = 3;
        }




        if (pom==0)
        {
            player.position = Vector3.MoveTowards(player.position, pozicije[polje[currPos][0]].position, speed * Time.fixedDeltaTime);
            if (player.position == pozicije[polje[currPos][0]].position)
            {
                currPos = polje[currPos][0];
                pom = -1;
            }
        }
        else if (pom==1)
        {
            player.position = Vector3.MoveTowards(player.position, pozicije[polje[currPos][1]].position, speed * Time.fixedDeltaTime);
            if (player.position == pozicije[polje[currPos][1]].position)
            {
                currPos = polje[currPos][1];
                pom = -1;
            }
        }
        else if (pom==2)
        {
            player.position = Vector3.MoveTowards(player.position, pozicije[polje[currPos][2]].position, speed * Time.fixedDeltaTime);
            if (player.position == pozicije[polje[currPos][2]].position)
            {
                currPos = polje[currPos][2];
                pom = -1;
            }
                
        }
        else if (pom==3)
        {
            player.position = Vector3.MoveTowards(player.position, pozicije[polje[currPos][3]].position, speed * Time.fixedDeltaTime);
            if (player.position == pozicije[polje[currPos][3]].position)
            {
                currPos = polje[currPos][3];
                pom = -1;
            }
        }


    }
    
}
