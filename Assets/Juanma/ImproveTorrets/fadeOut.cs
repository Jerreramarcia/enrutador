using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeOut : MonoBehaviour
{
    // Start is called before the first frame update
    public Text texto;
    public float x;
    public float y;
    bool improved = true;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        x = this.gameObject.transform.position.x;
        y = this.gameObject.transform.position.y;
    
        transform.position += Vector3.up;
        texto.CrossFadeAlpha(0, 0.455f, false);
    
    }

    public void setPosition(int x, int y){
        transform.position= new Vector2(x,y); 
    }

    public void Improve(){
        improved = true;
    }

}
