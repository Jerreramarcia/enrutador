using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionTorreta : MonoBehaviour
{
    void Start()
    {
        
    }

    public bool open = false;

    void OnMouseOver()
    {
        // Comprueba si los hijos (Botones de conseguir torreta) son visibles o no
        if (Input.GetMouseButtonDown(0))
        {
            if (open == false)
            {
                for (int a = 0; a < transform.childCount; a++)
                {
                    transform.GetChild(a).gameObject.SetActive(true);
                }
                open = false;
            } else if (open == true) {
                for (int a = 0; a < transform.childCount; a++)
                {
                    transform.GetChild(a).gameObject.SetActive(false);
                }
                open = true;
            }
        }
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
    }

}

