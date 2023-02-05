using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeOut : MonoBehaviour
{
    // Start is called before the first frame update
    public Text texto;
    bool improved = false;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(improved){
            transform.localPosition += Vector3.up;
            texto.CrossFadeAlpha(0, 0.455f, false);
        }
    }

    public void setPositio(int x, int y){
        transform.localPosition= new Vector2(x,y); 
    }

    public void Improve(){
        improved = true;
    }

}
