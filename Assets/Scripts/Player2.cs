using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    float speed = 5;
    float time = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 2) time = 0;
        float Horizontal = Input.GetAxis("Horizontal")*Time.deltaTime*speed  ;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        Vector3 move = new Vector3(Horizontal , vertical, 0);
        
        
        transform.position += move;

        for (int i = 0; i < Global.enemies.Count; i++)
        {
            GameObject enemy = Global.enemies[i];

            float distance = Vector3.Distance(transform.position, enemy.transform.position);
            if (distance < 1) 
            {
                Debug.Log("colision!!!!");
            }
        }
 

    }
}
