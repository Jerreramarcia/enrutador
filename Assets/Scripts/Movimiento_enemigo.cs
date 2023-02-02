using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<Transform>().position.y > 1.5)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -30f * Time.deltaTime));
        }
        

    }
}
