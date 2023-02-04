using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Habilidad : MonoBehaviour
{

    public GameObject boton1;
    public GameObject boton2;
    // Start is called before the first frame update
    public void parar()
    {
        Time.timeScale = 1.0f;
        boton1.SetActive(false);
        boton2.SetActive(false);

    }
}
