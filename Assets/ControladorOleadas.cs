using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class ControladorOleadas : MonoBehaviour
{
    public static ControladorOleadas Instance;
    public Text Oleada;
    private string texto;
    public Text saaavia;
    private string texto2;

    public GameObject mapa1;

    public GameObject mapa2;

    public GameObject arbol;

    public GameObject mapa3;

    public GameObject mapa4;
    private bool oleada1 = false;   
    private bool oleada2 = false;
    private bool oleada3 = false;
    private bool oleada4 = false;
    private float tiempo_inicio = 5f;
    private float tiempo_espera = 3f;
    private int numero_aleatorio;
    private bool empieza = false;
    private bool empieza2 = false;
    [SerializeField] private AudioClip oleadasonido;
    public GameObject bicho1;
    public GameObject bicho2;
    public GameObject bicho3;
    public GameObject bicho4;

    public GameObject bicho5;

    public GameObject bicho6;

    int contador = 0;
    public float muertes = 0;
    public int savia = 0;
  


    // Start is called before the first frame update
    void Start()
    {

     
        
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

        

        //Oleada 1


        if (tiempo_inicio <= 0 && empieza == false)
        {
            texto = "Oleada 1";
            ControladorSonido.Instance.EjecutarSonido(oleadasonido);
            Oleada.text = texto;
            empieza = true;
        }
        else
        {
            tiempo_inicio -= Time.deltaTime;
        }

        if (empieza == true)
        {

                if (contador >= 10)
                {
                    texto = "Oleada 2";
                    arbol.gameObject.GetComponent<ArbolScript>().level = 2;
                    
                    mapa1.SetActive(true);
                    ControladorSonido.Instance.EjecutarSonido(oleadasonido);
                    Oleada.text = texto;
                    
                    if (contador >= 20)
                    {
                        texto = "Oleada 3";
                        arbol.gameObject.GetComponent<ArbolScript>().level = 3;

                         mapa2.SetActive(true);
                        ControladorSonido.Instance.EjecutarSonido(oleadasonido);
                        Oleada.text = texto;
                        oleada1 = false;
                        oleada2 = true;
                        if (contador >= 25)
                        {
                            texto = "Oleada 4";
                            arbol.gameObject.GetComponent<ArbolScript>().level = 4;

                             mapa3.SetActive(true);
                            ControladorSonido.Instance.EjecutarSonido(oleadasonido);
                            Oleada.text = texto;
                            oleada2 = false;
                            oleada3 = true;
                            if (contador >= 30)
                            {
                                mapa4.SetActive(true);
                                oleada3 = false;
                                texto = "Oleada 5";
                                ControladorSonido.Instance.EjecutarSonido(oleadasonido);
                                Oleada.text = texto;
                            }

                        else
                        {

                            if (tiempo_espera <= 0)
                            {
                                numero_aleatorio = Random.Range(1, 7);
                                Debug.Log(numero_aleatorio);

                                if (numero_aleatorio == 1)
                                {
                                    Instantiate(bicho1);
                                    contador = contador + 1;
                                }

                                if (numero_aleatorio == 2)
                                {
                                    Instantiate(bicho2);
                                    contador = contador + 1;
                                }

                                if (numero_aleatorio == 3)
                                {
                                    Instantiate(bicho3);
                                    contador = contador + 1;
                                }

                                tiempo_espera = 3f;
                            }
                            else
                            {
                                tiempo_espera -= Time.deltaTime;
                            }


                        }
                    }
                    else
                    {

                        if (tiempo_espera <= 0)
                        {
                            numero_aleatorio = Random.Range(1, 7);
                            Debug.Log(numero_aleatorio);

                            if (numero_aleatorio == 1)
                            {
                                Instantiate(bicho1);
                                contador = contador + 1;
                            }

                            if (numero_aleatorio == 2)
                            {
                                Instantiate(bicho2);
                                contador = contador + 1;
                            }

                            if (numero_aleatorio == 3)
                            {
                                Instantiate(bicho3);
                                contador = contador + 1;
                            }

                             if (numero_aleatorio == 4)
                        {
                            Instantiate(bicho4);
                            contador = contador + 1;
                        }

                        if (numero_aleatorio == 5)
                        {
                            Instantiate(bicho5);
                            contador = contador + 1;
                        }

                        if (numero_aleatorio == 6)
                        {
                            Instantiate(bicho6);
                            contador = contador + 1;
                        }

                            tiempo_espera = 3f;
                        }
                        else
                        {
                            tiempo_espera -= Time.deltaTime;
                        }


                    }
                }
                else
                {

                    if (tiempo_espera <= 0)
                    {
                        numero_aleatorio = Random.Range(1, 7);
                        Debug.Log(numero_aleatorio);

                        if (numero_aleatorio == 1)
                        {
                            Instantiate(bicho1);
                            contador = contador + 1;
                        }

                        if (numero_aleatorio == 2)
                        {
                            Instantiate(bicho2);
                            contador = contador + 1;
                        }

                        if (numero_aleatorio == 3)
                        {
                            Instantiate(bicho3);
                            contador = contador + 1;
                        }
                        if (numero_aleatorio == 4)
                        {
                            Instantiate(bicho4);
                            contador = contador + 1;
                        }

                        if (numero_aleatorio == 5)
                        {
                            Instantiate(bicho5);
                            contador = contador + 1;
                        }

                        if (numero_aleatorio == 6)
                        {
                            Instantiate(bicho6);
                            contador = contador + 1;
                        }

                        tiempo_espera = 3f;
                    }
                    else
                    {
                        tiempo_espera -= Time.deltaTime;
                    }


                }

            }
            else
            {

                if (tiempo_espera <= 0)
                {

                   
                        numero_aleatorio = Random.Range(1, 7);
                        Debug.Log(numero_aleatorio);

                        if (numero_aleatorio == 1)
                        {
                            Instantiate(bicho1);
                            contador = contador + 1;
                        }

                        if (numero_aleatorio == 2)
                        {
                            Instantiate(bicho2);
                            contador = contador + 1;
                        }

                        if (numero_aleatorio == 3)
                        {
                            Instantiate(bicho3);
                            contador = contador + 1;
                        }

                        if (numero_aleatorio == 4)
                        {
                            Instantiate(bicho4);
                            contador = contador + 1;
                        }

                        if (numero_aleatorio == 5)
                        {
                            Instantiate(bicho5);
                            contador = contador + 1;
                        }

                        if (numero_aleatorio == 6)
                        {
                            Instantiate(bicho6);
                            contador = contador + 1;
                        }

                        tiempo_espera = 3f;

                }
                else
                {

                    tiempo_espera -= Time.deltaTime;
                }
            }


            }

    }

    public void ContadoMuertes()
    {
        muertes = muertes + 1;
    }

    public void SumarSavia(int sumasavia)
    {
        savia = savia + sumasavia;
        texto2 = savia.ToString();
        saaavia.text = texto2;
    }

    public void RestarSavia(int restarsavia)
    {
        savia = savia - restarsavia;
        texto2 = savia.ToString();
        saaavia.text = texto2;

    }
}
