using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LifeCount : MonoBehaviour
{
    private static int previous_lifeCount = 5;
    public GameObject textLife;
    public GameObject gameOver;
    private void Start()
    {
        textLife.GetComponent<Text>().text = "Life: X" + Mario.health.ToString();
    }
    void Update()
    {
        if (Mario.health <= 0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
        if(Mario.health == previous_lifeCount-1)
        {
            previous_lifeCount--;
            textLife.GetComponent<Text>().text = "Life: X" + Mario.health.ToString();
        }
    }
}
