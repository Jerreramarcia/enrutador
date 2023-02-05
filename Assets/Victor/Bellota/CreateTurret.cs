using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTurret : MonoBehaviour
{
    [SerializeField]
    private GameObject towerPrefab;

    public GameObject TowerPrefab
    {
        get
        {
            return towerPrefab;
        }
    }

    void OnMouseDown() 
    {
        PlaceTower();
    }

    private void PlaceTower()
    {
        Instantiate(TowerPrefab, transform.parent.position, Quaternion.identity);
        this.transform.parent.gameObject.SetActive(false);
    }
}