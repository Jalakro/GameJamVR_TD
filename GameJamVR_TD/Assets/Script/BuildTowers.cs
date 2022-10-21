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
        
    }

    public void SpawnSaw()
    {
        GameObject tower = Instantiate(Prefab[0], new Vector3(4.7f, 1.75f, 6.4f), Quaternion.identity);
        CurrentTowers.Add(tower);
    }

    public void SpawnObstacle()
    {
        GameObject tower = Instantiate(Prefab[1], new Vector3(4.7f, 1.75f, 6.05f), Quaternion.identity);
        CurrentTowers.Add(tower);
    }
}
