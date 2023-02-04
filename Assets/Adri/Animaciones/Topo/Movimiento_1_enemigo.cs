using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_1_enemigo : MonoBehaviour
{
    public float velocidadX;
    public float velocidadY;
    public float velocidadY2;
    public float tiempo1 = 8f;
    public float tiempo2 = 5f;
    public bool dentro = true;
    private bool primer_camino = false;
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
    private bool duodecimo_camino = false;
    private bool tridecimo_camino = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<Transform>().position.x < -6.54 && primer_camino == false )
        {
            gameObject.transform.Translate(velocidadX * Time.deltaTime, 0, 0);

        }
        else
        {
            primer_camino = true;
        }

        if (gameObject.GetComponent<Transform>().position.y < -3.61 && segundo_camino == false)
        {
            gameObject.transform.Translate(0, velocidadY * Time.deltaTime, 0);
        }
        else
        {
            segundo_camino= true;
        }

        if(primer_camino== true && segundo_camino == true)
        {
            if (gameObject.GetComponent<Transform>().position.x > -6.72 && tercer_camino == false)
            {
                gameObject.transform.Translate(-velocidadX * Time.deltaTime, 0, 0);

            }
            else
            {
                tercer_camino = true;
            }

            if (gameObject.GetComponent<Transform>().position.y < -2.22 && cuarto_camino == false)
            {
                gameObject.transform.Translate(0, velocidadY * Time.deltaTime, 0);
            }
            else
            {
                cuarto_camino = true;
            }

            if(tercer_camino == true && cuarto_camino == true)
            {
                if (gameObject.GetComponent<Transform>().position.x < -5.17 && quinto_camino == false)
                {
                    gameObject.transform.Translate(velocidadX * Time.deltaTime, 0, 0);

                }
                else
                {
                    quinto_camino = true;
                }

                if (gameObject.GetComponent<Transform>().position.y < -1.06 && sexto_camino == false)
                {
                    gameObject.transform.Translate(0, velocidadY * Time.deltaTime, 0);
                }
                else
                {
                    sexto_camino = true;
                }

                if(quinto_camino == true && sexto_camino == true)
                {
                    if (gameObject.GetComponent<Transform>().position.x < 1.8 && septimo_camino == false)
                    {
                        gameObject.transform.Translate(velocidadX * Time.deltaTime, 0, 0);

                    }
                    else
                    {
                        septimo_camino = true;
                    }

                    if (gameObject.GetComponent<Transform>().position.y > -1.74 && octavo_camino == false)
                    {
                        gameObject.transform.Translate(0, -velocidadY2 * Time.deltaTime, 0);
                    }
                    else
                    {
                        octavo_camino = true;
                    }

                    if (septimo_camino == true && octavo_camino == true)
                    {
                        if (gameObject.GetComponent<Transform>().position.x < 4.48 && noveno_camino == false)
                        {
                            gameObject.transform.Translate(velocidadX * Time.deltaTime, 0, 0);

                        }
                        else
                        {
                            noveno_camino = true;
                        }

                        if (gameObject.GetComponent<Transform>().position.y < -1.50 && decimo_camino == false)
                        {
                            gameObject.transform.Translate(0, velocidadY2 * Time.deltaTime, 0);
                        }
                        else
                        {
                            decimo_camino = true;
                        }
                        if (noveno_camino == true && decimo_camino == true)
                        {
                            if(gameObject.GetComponent<Transform>().position.y < 0.21 && undecimo_camino == false)
                            {
                                gameObject.transform.Translate(0, velocidadY * Time.deltaTime, 0);
                            
                            }
                            else
                            {
                                undecimo_camino = true;
                            }

                            if(undecimo_camino == true)
                            {

                                if (gameObject.GetComponent<Transform>().position.x > 0.29 && duodecimo_camino == false)
                                {
                                    gameObject.transform.Translate(-velocidadX * Time.deltaTime, 0, 0);

                                }
                                else
                                {
                                    duodecimo_camino = true;
                                }

                                if (gameObject.GetComponent<Transform>().position.y < 0.42 && tridecimo_camino == false)
                                {
                                    gameObject.transform.Translate(0, velocidadY2 * Time.deltaTime, 0);
                                }
                                else
                                {
                                    tridecimo_camino = true;
                                }




                            }
                        }
                    }

                }

            }

        }


        if(dentro == true)
        {
            if(tiempo1 <= 0)
            {
                dentro = false;
                tiempo1 = 10f;
                gameObject.GetComponent<Animator>().SetBool("dentro", true);
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
            }

            tiempo1 -= Time.deltaTime;
        }
        else
        {

            if(tiempo2 <= 0)
            {
                dentro = true;
                tiempo2 = 5f;
                gameObject.GetComponent<Animator>().SetBool("dentro", false);
                gameObject.GetComponent<BoxCollider2D>().enabled = true;
            }

            tiempo2 -= Time.deltaTime;


        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "muerte")
        {
            Destroy(gameObject);

        }
    }
}
