using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaTorreta : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
        MoveToTarget(PrefabDisparo, target);
    }

    [SerializeField]
    private GameObject PrefabDisparo;

    [SerializeField]
    private int damage = 10;

    [SerializeField]
    private int velocidadBala = 1;

    [SerializeField]
    private float attackCooldown = 3;

    [SerializeField]
    private int precioCompra = 10;

    [SerializeField]
    private int precioMejora = 20;

    [SerializeField]
    private int aumentoDanoMejora = 10;

    [SerializeField]
    private int aumentoVelBalaMejora = 2;

    private bool canAttack = true;

    private float attackTimer = 0;

    private Movimiento_enemigo target;

    private Queue<Movimiento_enemigo> enemies = new Queue<Movimiento_enemigo>();

    private void MoveToTarget(GameObject prefabToMove, Movimiento_enemigo targetToHit){
        if(targetToHit != null && targetToHit.gameObject.activeSelf)
        {
            Debug.Log(prefabToMove.transform.position);
            PrefabDisparo.transform.position = Vector3.MoveTowards(transform.position, targetToHit.getPosicion(), Time.deltaTime * velocidadBala);
        }
    }

    private void Attack()
    {
        if (!canAttack)
        {
            attackTimer += Time.deltaTime;

            if (attackTimer >= attackCooldown) 
            {
                canAttack = true;
                attackTimer = 0;
            }
        }

        if(target == null && enemies.Count > 0)
        {
            target = enemies.Dequeue();
        }
        if (target != null && target.gameObject.activeSelf)
        {
            if(canAttack)
            {
                Shoot(target);
                canAttack = false;
            }
        }
    }

    private void Shoot(Movimiento_enemigo trgt)
    {
        Instantiate(PrefabDisparo, transform.parent.position, Quaternion.identity);
    
        MoveToTarget(PrefabDisparo, trgt);

        Debug.Log("He disparado");

        trgt.Quitarvida(damage);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "enemy")
        {
            enemies.Enqueue(other.GetComponent<Movimiento_enemigo>());
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "enemy")
        {
            target = null;
        }
    }

    public void UpgradeTurret(){
        damage += aumentoDanoMejora;
        velocidadBala += aumentoVelBalaMejora;
    }
}
