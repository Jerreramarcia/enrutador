using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeOut : MonoBehaviour
{
    // Start is called before the first frame update
    public Text texto;
    public bool _fadein = false;
    public bool _fadeout = false;
    public float position_x = -97.18f;
    public float position_y = -185f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        //transform.position = new Vector2(transform.position.x,transform.position.y+1); 
        transform.position = new Vector3(position_x,position_y,0f); 

        //texto.CrossFadeAlpha(0, 0.455f, false);
    }

}
