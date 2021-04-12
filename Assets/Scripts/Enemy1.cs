using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    //public GameObject bullet1;
    Vector3 start, end;
    float t;
    float speed = 0;
    void Start()
    {
        speed = 0.05f;
        start = new Vector3(12, Random.Range(7, -7),0);
        end = new Vector3(-10, Random.Range(8 ,- 7), 0);
        transform.position = start;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 1) t = 1;
        Vector3 linearMove = new Vector3(-t * speed + transform.position.x, transform.position.y, 0);
        transform.position = linearMove;
        Destroy(gameObject, 5);

        GameObject player = GameObject.Find("Player");
        float distance = Vector3.Distance(transform.position,player.transform.position);

        GameObject Bullet = (GameObject)Resources.Load("Bullet");
        float bulletDistance = Vector3.Distance(gameObject.transform.position,Bullet.transform.position);

        foreach ( GameObject o in Object.FindObjectsOfType<GameObject>())
        {
            if (bulletDistance < 1)
            {
               // print("great!");
                Global.enemies.Remove(gameObject);
                Destroy(gameObject,5f);
            }
        }
       
        if (distance < 1)
        {
            
            Global.enemies.Remove(gameObject);
            //Destroy(gameObject);
        }
        
    }
}
