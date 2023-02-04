using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento_enemigo : MonoBehaviour
{

    public float velocidad = 0;
    public float vida=100;
    public int dmg=1;
    public int multiplicadorDmg = 1;
    public float multiplicadorDmgRecibido = 1f;

    public GameObject arbol;
    
    ArbolScript arbolScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<Transform>().position.y > 1.5)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -velocidad * Time.deltaTime));
        
        
        }else if(gameObject.GetComponent<Transform>().position.x > -2.4){


            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-velocidad * Time.deltaTime, 0f));


        }else if(gameObject.GetComponent<Transform>().position.y > -3.9)
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, -velocidad * Time.deltaTime));

        }
        

    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Entramos");
        if (collision.gameObject.tag == "Finish")
        {
            gameObject.SetActive(false);
            collision.gameObject.GetComponent<ArbolScript>().takeDmg(dmg*multiplicadorDmg);
            //UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }

}
