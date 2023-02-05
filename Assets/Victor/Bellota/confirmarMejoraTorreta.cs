using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class confirmarMejoraTorreta : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myPrefab;
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
            Instantiate(myPrefab, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0), Quaternion.identity);
            this.gameObject.SetActive(false);
        }
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on confirmarMejroaTorreta.");
    }
}
