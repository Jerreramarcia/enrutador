using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botonTorreta : MonoBehaviour
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
}
