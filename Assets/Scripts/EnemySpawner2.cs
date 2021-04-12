using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner2 : MonoBehaviour
{
    public GameObject enemy;
    float time = 0;
    void Start()
    {
        enemy = (GameObject)Resources.Load("Enemy1");
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 2) 
        {
            Spawn();
            time = 0;
        }
       // Debug.Log(Global.enemies.Count);
    }

    public void Spawn() 
    {
        Instantiate(enemy);
        Global.enemies.Add(enemy);
    }

}
