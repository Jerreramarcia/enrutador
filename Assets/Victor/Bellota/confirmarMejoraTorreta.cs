using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confirmarMejoraTorreta : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Click boton mejora");
            this.transform.parent.GetComponent<LogicaTorreta>().UpgradeTurret();
            this.gameObject.SetActive(false);
        }
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on confirmarMejroaTorreta.");
    }
}
