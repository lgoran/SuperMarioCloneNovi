using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Mario_data
{
    public int health ;
    public int coins;
    public int score ;
    public string velicina;//mali veliki ludi
    public int[] leveli;
    public float[] pozicija;
    public Mario_data(Mario player)
    {
        health = player.health;
        coins = player.coins;
        score = player.score;
        velicina = player.velicina;
        leveli = player.leveli;
        pozicija = new float[3];
        pozicija[0] = player.transform.position.x;
        pozicija[1] = player.transform.position.y;
        pozicija[2] = player.transform.position.z;
    }
}
