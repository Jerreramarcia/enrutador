using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    //Testing
    // [SerializeField]
    // private GameObject towerPrefab;

    // public GameObject TowerPrefab
    // {
    //     get
    //     {
    //         return towerPrefab;
    //     }
    // }

    public botonTorreta ClickedBtn { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickTower(botonTorreta botonTorr)
    {
        this.ClickedBtn = botonTorr;
    }
}
