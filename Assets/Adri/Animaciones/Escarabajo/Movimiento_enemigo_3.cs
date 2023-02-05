using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_enemigo_3 : MonoBehaviour
{
    public float VelocidadX;
    public float VelocidadY;
    public float VelocidadY2;
    private bool primer_camino = false;
    private bool segundo_camino = false;
    private bool tercer_camino = false;
    private bool cuarto_camino = false;
    private bool quinto_camino = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<Transform>().position.x > 4.69 && primer_camino == false)
        {
            gameObject.transform.Translate(-VelocidadX * Time.deltaTime, 0, 0);

        }
        else
        {
            primer_camino = true;
        }

        if (gameObject.GetComponent<Transform>().position.y < -0.6 && segundo_camino == false)
        {

            gameObject.transform.Translate(0, VelocidadY2 * Time.deltaTime, 0);

        }
        else
        {

            segundo_camino = true;

        }

        if(primer_camino == true && segundo_camino == true)
        {

            if (gameObject.GetComponent<Transform>().position.y < 0.21 && tercer_camino == false)
            {
                gameObject.transform.Translate(0, VelocidadY * Time.deltaTime, 0);

            }
            else
            {
                tercer_camino = true;
            }

            if(tercer_camino == true)
            {

                if (gameObject.GetComponent<Transform>().position.x > 0.29 && cuarto_camino == false)
                {
                    gameObject.transform.Translate(-VelocidadX * Time.deltaTime, 0, 0);

                }
                else
                {
                    cuarto_camino = true;

                }


                if (gameObject.GetComponent<Transform>().position.y < 0.42 && quinto_camino == false)
                {
                    gameObject.transform.Translate(0, VelocidadY2 * Time.deltaTime, 0);
                }
                else
                {
                    quinto_camino = true;


                }
            }

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Finish")
        {

            ControladorSonido.Instance.SumarMuertes();
            gameObject.SetActive(false);
            

        }
    }
}
