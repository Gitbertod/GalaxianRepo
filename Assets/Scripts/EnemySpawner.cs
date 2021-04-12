using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy1;
    float time;
   
    void Start()
    {
        enemy1 =(GameObject)Resources.Load("Enemy1");
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time >= 2)
        {
            time = 0;
            Spawn();
        }
    }
    void Spawn() 
    {
        Instantiate(enemy1);
       
    }
}
