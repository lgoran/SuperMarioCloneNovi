using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public GameObject cointext;
    public static int brojac=0;
    private static int brojac_previous = 0;
    void Update()
    {
        if (brojac == brojac_previous + 1)
        {
            cointext.GetComponent<Text>().text = "Coins:" + brojac.ToString();
            brojac_previous++;
        }
    }
}
