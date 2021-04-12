using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameObject player;
    float time;
    
    float limitY = 0;
    float startY = 6;
    float endY = -20;

    float limitX = 0;
    float startX = -9;
    float endX = 9;
    
    float speed = 0;
    float tY = 0;
    float tx = 0;
    Vector3 directionInput; 
    void Start()
    {
    
        limitY = 0;
        speed = 5;
    }


    void Update()
    {
       
        //Moviento del player en Horizontal
        float moveX = Input.GetAxis("Horizontal")* speed * Time.deltaTime;

        //Moviemto del player en Vertical
        float moveY = Input.GetAxis("Vertical")* speed * Time.deltaTime;
        directionInput = new Vector3(moveX, moveY);

        //limites de movimento
        transform.position += directionInput;
        
        //Limite vertical
        if (transform.position.y <= -4)
        {
            transform.position = new Vector3(transform.position.x, -4, 0); 
        }
        if(transform.position.y >= 6) 
        {
            transform.position = new Vector3(transform.position.x, 6, 0);
        }
        
        //limite Horizontal
        if (transform.position.x <= -9) 
        {
            transform.position = new Vector3(-9, transform.position.y, 0);
        }
        if(transform.position.x >= 9) 
        {
            transform.position = new Vector3(9, transform.position.y, 0);
        }
    }
    
}
