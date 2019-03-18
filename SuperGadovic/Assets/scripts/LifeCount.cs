using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LifeCount : MonoBehaviour
{

    public static int lifeCount = 5;
    private static int previous_lifeCount = 5;
    public GameObject textLife;
    public GameObject gameOver;
    private void Start()
    {
        textLife.GetComponent<Text>().text = "Life: X" + lifeCount.ToString();
    }
    void Update()
    {
        if (lifeCount <= 0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
        if(lifeCount==previous_lifeCount-1)
        {
            previous_lifeCount--;
            textLife.GetComponent<Text>().text = "Life: X" + lifeCount.ToString();
        }
    }
}
