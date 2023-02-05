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
    private float tiempo_inicio = 5f;
    private float tiempo_espera = 3f;
    private int numero_aleatorio;
    private bool empieza = false;
    private bool empieza2 = false;
    [SerializeField] private AudioClip oleadasonido;
    public GameObject bicho1;
    public GameObject bicho2;
    public GameObject bicho3;
    int contador = 0;
    int contador2 = 10;
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
            if (contador2 == contador)
            {


            }
            else
            {

                if (tiempo_espera <= 0)
                {

                    Instantiate(bicho3);
                    contador++;
                    tiempo_espera = 4f;

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
