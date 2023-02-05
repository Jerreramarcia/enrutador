using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject toShow;

    void Update(){

        if(toShow.gameObject.activeSelf == true){
            Time.timeScale = 0f;
            if (Input.GetKeyDown(KeyCode.Mouse0)){

                toShow.gameObject.SetActive(false);
                Time.timeScale = 1f;

            }

        }

    }
}
