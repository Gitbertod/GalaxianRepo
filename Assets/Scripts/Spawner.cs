using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            Shoot();
        }
    }
    void Shoot() 
    {
        
        Instantiate(Resources.Load("Bullet"),transform.position,transform.rotation);
    }
}
