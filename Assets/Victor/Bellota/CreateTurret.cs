using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTurret : MonoBehaviour
{
    [SerializeField]
    private GameObject towerPrefab;

    [SerializeField]
    private int precioCompra = 10;

    [SerializeField]
    private int precioMejora = 20;

    public GameObject TowerPrefab
    {
        get
        {
            return towerPrefab;
        }
    }

    void OnMouseDown() 
    {
        if(ControladorOleadas.Instance.savia > precioCompra)
        {

            PlaceTower();

            ControladorOleadas.Instance.RestarSavia(precioCompra);

        }

    
    }

    private void PlaceTower()
    {
        Instantiate(TowerPrefab, transform.parent.position, Quaternion.identity);
        this.transform.parent.gameObject.SetActive(false);
    }
}