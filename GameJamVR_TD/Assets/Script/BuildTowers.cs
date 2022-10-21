using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildTowers : MonoBehaviour
{

    public List<GameObject> CurrentTowers;
    public List<GameObject> Prefab = new List<GameObject>();

    public int towerID;

    public bool test;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (test)
        {
            InstantiateTower(1, 1);
        }
    }

    public void InstantiateTower(int buttonIDx, int buttonIDy)
    {
        GameObject tower = Instantiate(Prefab[towerID], new Vector3(buttonIDx * 2.0f, 1, buttonIDy * 1), Quaternion.identity);
        CurrentTowers.Add(tower);
    }

    public void SelectTower(int p_towerID)
    {
        towerID = p_towerID;
    }
}
