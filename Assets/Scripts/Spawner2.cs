using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1")) 
        {
            Shoot();

        }
    }


    void Shoot() 
    {
        Instantiate(Resources.Load("Bullet"), transform.position, transform.rotation);

    }

}
