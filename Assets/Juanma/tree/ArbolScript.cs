using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArbolScript : MonoBehaviour
{
    public int vida = 100;
    // Start is called before the first frame update
    void Start()
    {
        setHealthBar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDmg(int dmg){
        if(vida>=0){
            this.vida -= dmg;
        }
    }

    public void setHealthBar(){
        float my_Health = vida;
    }
    public int getVida(){
        return vida;
    }
}
