using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    public int health = LifeCount.lifeCount;
    public int coins = CoinCounter.brojac;
    public int score = 0;
    public string velicina = "mali";//mali veliki ludi
    public int[] leveli = new int[] {0,0,0,0};
    
}
