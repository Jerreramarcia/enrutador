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

    // Start is called before the first frame update
    void Start()
    {        
          
    }

    // Update is called once per frame
    void Update()
    {
         

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "enemy")
        {
            Physics2D.IgnoreCollision( collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }

}
