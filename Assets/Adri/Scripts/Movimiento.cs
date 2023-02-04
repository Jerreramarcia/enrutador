using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad;
    public GameObject boton1;
    public GameObject boton2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {

            gameObject.transform.Translate(-velocidad * Time.deltaTime, 0, 0);


        }

        if (Input.GetKey("right"))
        {

            gameObject.transform.Translate(velocidad * Time.deltaTime, 0, 0);


        }

        if(Time.timeScale == 0)
        {

           



        }

    }

}

