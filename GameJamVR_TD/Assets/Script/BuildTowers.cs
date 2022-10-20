using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildTowers : MonoBehaviour
{

    List<GameObject> CurrentTowers;
    public List<GameObject> Prefab = new List<GameObject>();

    public int towerID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateTower(int buttonID)
    {
        GameObject tower = Instantiate(Prefab[towerID]); // GERER POS DE SPAWN
        CurrentTowers.Add(tower);
    }

    public void SelectTower(int p_towerID)
    {
        towerID = p_towerID;
    }
}
