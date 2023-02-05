using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArbolScript : MonoBehaviour
{
    public int vida = 100;

    [SerializeField] Text hpText;
    [SerializeField] Image hpBar;
    public Sprite arbol1;
    public Sprite arbol2;
    public Sprite arbol3;
    public Sprite arbol4;
    public SpriteRenderer spriteRenderer;
    [SerializeField]GameObject arbol;
    public int level = 1;
    ArbolScript arbolScript;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch(level){
            case 1:
                spriteRenderer.sprite = arbol1;
                break;
            
            case 2:
                spriteRenderer.sprite = arbol2;
                break;
            
            case 3:
                spriteRenderer.sprite = arbol3;
                break;
            
            case 4:
                spriteRenderer.sprite = arbol4;
                break;
        }
        hpBar.fillAmount =(float) arbol.gameObject.GetComponent<ArbolScript>().vida/ 100;   
        hpText.text = arbol.gameObject.GetComponent<ArbolScript>().vida.ToString() + " HP";
    }

    public void takeDmg(int dmg){
        if(vida>=0){
            this.vida -= dmg;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
   


        
        if (collision.gameObject.tag == "enemy")
        {
            this.takeDmg(collision.gameObject.GetComponent<Movimiento_enemigo>().dmg*collision.gameObject.GetComponent<Movimiento_enemigo>().multiplicadorDmg);
            hpText.text = this.vida.ToString() + " HP";
            hpText.text = this.vida.ToString() + " HP";
            hpBar.fillAmount = (float)this.vida / 100;
            collision.gameObject.SetActive(false);
            //UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }
    public int getVida(){
        return vida;
    }
}
