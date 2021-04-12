using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject enemy1;
    //Vector3 bullet1;
    float distance;
    float speed = 1;
    float start, end;
    float time = 0;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        
        distance = Vector3.Distance(transform.position, enemy1.transform.position);

       // if (distance < 1) Destroy(gameObject);

        transform.position = new Vector3(time + transform.position.x, transform.position.y, 0);
        Destroy(gameObject, 2);

    }
}
