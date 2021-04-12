using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timeText;
    public Text Score;
    float gameTime,score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        gameTime += Time.deltaTime;
        timeText.text = gameTime.ToString("0:00");


        
    }
}
