using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject canvas;

    void Update(){

        if(Input.GetKeyDown(KeyCode.Escape)){

            Time.timeScale = 0f;
            canvas.gameObject.SetActive(!canvas.gameObject.activeSelf);

        }
        if (canvas.gameObject.activeSelf == false) {
            Time.timeScale = 1f;
        }

    }
}