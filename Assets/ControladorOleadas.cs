using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class ControladorOleadas : MonoBehaviour
{
    public Text Oleada;
    private string texto;
    private float tiempo_inicio = 5f;
    private float tiempo_espera = 4f;
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


    // Start is called before the first frame update
    void Start()
    {

     
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(muertes);

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

        if(empieza == true)
        {
            if(contador2 == contador)
            {


            }
            else
            {

                if(tiempo_espera <= 0)
                {

                    Instantiate(bicho1);
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
}
