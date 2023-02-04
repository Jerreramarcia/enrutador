using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject canvas;

    void Update(){

        if(Input.GetKeyDown(KeyCode.Escape)){

            canvas.gameObject.SetActive(!canvas.gameObject.activeSelf);

        }

    }
}