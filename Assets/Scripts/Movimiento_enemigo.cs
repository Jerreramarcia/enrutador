using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_enemigo : MonoBehaviour
{

    public float velocidad = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<Transform>().position.y > 1.5)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -velocidad * Time.deltaTime));
        
        
        }else if(gameObject.GetComponent<Transform>().position.x > -2.4){


            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-velocidad * Time.deltaTime, 0f));


        }else if(gameObject.GetComponent<Transform>().position.y > -3.9)
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -velocidad * Time.deltaTime));

        }
        

    }
}
