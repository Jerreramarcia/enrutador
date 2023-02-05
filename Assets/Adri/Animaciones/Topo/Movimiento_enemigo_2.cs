using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_enemigo_2 : MonoBehaviour
{
    public float VelocidadX;
    public float VelocidadY2;
    public float VelocidadY;
    private  bool primer_camino = false;
    private bool segundo_camino = false;
    private bool tercer_camino = false;
    private bool cuarto_camino = false;
    private bool quinto_camino = false;
    private bool sexto_camino = false;
    private bool septimo_camino = false;
    private bool octavo_camino = false;
    private bool noveno_camino = false;
    private bool decimo_camino = false;
    private bool undecimo_camino = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    

        if(gameObject.GetComponent<Transform>().position.y < -3.33 && primer_camino == false)
        {
            gameObject.transform.Translate(0, VelocidadY * Time.deltaTime, 0);

        }
        else
        {
            primer_camino=true;
    
        
        }

        if (primer_camino == true)
        {
            if (gameObject.GetComponent<Transform>().position.x > 1.86 && segundo_camino == false)
            {
                gameObject.transform.Translate(-VelocidadX * Time.deltaTime, 0, 0);

            }
            else
            {
                segundo_camino = true;
            }

            if (gameObject.GetComponent<Transform>().position.y < -3.02 && tercer_camino == false)
            {

                gameObject.transform.Translate(0, VelocidadY * Time.deltaTime, 0);

            }
            else
            {

                tercer_camino = true;

            }

            if (segundo_camino == true && tercer_camino == true)
            {



                if (gameObject.GetComponent<Transform>().position.x > -1.67 && cuarto_camino == false)
                {
                    gameObject.transform.Translate(-VelocidadX * Time.deltaTime, 0, 0);

                }
                else
                {
                    cuarto_camino = true;

                }

                if (gameObject.GetComponent<Transform>().position.y > -3.1 && quinto_camino == false)
                {

                    gameObject.transform.Translate(0, -VelocidadY2 * Time.deltaTime, 0);

                }
                else
                {
                    quinto_camino = true;
                }

                if (quinto_camino == true && cuarto_camino == true)
                {
                    if (gameObject.GetComponent<Transform>().position.y < -1.55 && sexto_camino == false)
                    {
                        gameObject.transform.Translate(0, VelocidadY * Time.deltaTime, 0);
                    }
                    else
                    {
                        sexto_camino = true;
                    }

                    if (sexto_camino == true)
                    {

                        if (gameObject.GetComponent<Transform>().position.x < 4.48 && septimo_camino == false)
                        {
                            gameObject.transform.Translate(VelocidadX * Time.deltaTime, 0, 0);

                        }
                        else
                        {
                            septimo_camino = true;
                        }

                        if (gameObject.GetComponent<Transform>().position.y < -1.50 && octavo_camino == false)
                        {
                            gameObject.transform.Translate(0, VelocidadY2 * Time.deltaTime, 0);

                        }
                        else
                        {
                            octavo_camino = true;
                        }
                        if (septimo_camino == true && octavo_camino == true)
                        {

                            if (gameObject.GetComponent<Transform>().position.y < 0.21 && noveno_camino == false)
                            {
                                gameObject.transform.Translate(0, VelocidadY * Time.deltaTime, 0);

                            }
                            else
                            {
                                noveno_camino = true;
                            }

                            if (noveno_camino == true)
                            {

                                if (gameObject.GetComponent<Transform>().position.x > 0.29 && decimo_camino == false)
                                {
                                    gameObject.transform.Translate(-VelocidadX * Time.deltaTime, 0, 0);

                                }
                                else
                                {
                                    decimo_camino = true;
                                }

                                if (gameObject.GetComponent<Transform>().position.y < 0.42 && undecimo_camino == false)
                                {
                                    gameObject.transform.Translate(0, VelocidadY2 * Time.deltaTime, 0);
                                }
                                else
                                {
                                    undecimo_camino = true;
                                }

                            }
                        }
                    }
                }
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Finish")
        {

            ControladorSonido.Instance.SumarMuertes();
            ControladorOleadas.Instance.SumarSavia();
            gameObject.SetActive(false);


        }
    }


}
