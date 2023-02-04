using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public GameObject boton1;
    public GameObject boton2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "moneda")
        {

            Time.timeScale = 0f;
            boton1.SetActive(true);
            boton2.SetActive(true);

        }
    }

}
