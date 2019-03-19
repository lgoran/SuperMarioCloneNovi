using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    private static int brojac_previous, pom;
    public GameObject cointext;
    private void Start()
    {
        cointext.GetComponent<Text>().text = "Coins:" + Mario.coins.ToString();
        brojac_previous = Mario.coins;
        pom = 0;
    }
    void Update()
    {
        if (Map_class.povratak_u_scenu == 0 && pom == 0)
        {
            cointext.GetComponent<Text>().text = "Coins:" + Mario.coins.ToString();
            pom = 1;
        }
        if (Mario.coins == brojac_previous + 1)
        {
            cointext.GetComponent<Text>().text = "Coins:" + Mario.coins.ToString();
            brojac_previous++;
        }
    }
}
