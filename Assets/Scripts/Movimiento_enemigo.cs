using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movimiento_enemigo : MonoBehaviour
{

    public float velocidad = 0;
    public float vida=100;
    public int dmg=1;
    public int multiplicadorDmg = 1;
    public float multiplicadorDmgRecibido = 1f;
    [SerializeField] Text hpText;
    [SerializeField] Image hpBar;
    
    [SerializeField]GameObject arbol;
    
    ArbolScript arbolScript;
    // Start is called before the first frame update
    void Start()
    {        
          
    }

    // Update is called once per frame
    void Update()
    {
         
        hpBar.fillAmount =(float) arbol.gameObject.GetComponent<ArbolScript>().vida/ 100;   
        hpText.text = arbol.gameObject.GetComponent<ArbolScript>().vida.ToString() + " HP";


    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Entramos");
        if (collision.gameObject.tag == "Finish")
        {
            gameObject.SetActive(false);
            collision.gameObject.GetComponent<ArbolScript>().takeDmg(dmg*multiplicadorDmg);
            hpText.text = collision.gameObject.GetComponent<ArbolScript>().vida.ToString() + " HP";
            hpText.text = collision.gameObject.GetComponent<ArbolScript>().vida.ToString() + " HP";
            hpBar.fillAmount = collision.gameObject.GetComponent<ArbolScript>().vida / 100;
            //UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }

}
