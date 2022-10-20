using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieManager : MonoBehaviour
{

    List<GameObject> CurrentEnemies;
    public List<GameObject> Prefab = new List<GameObject>();
    public int enemieID;
    public bool enemieEnabled;

    public float score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (enemieEnabled)
        {
            StartCoroutine("SpawnEnemie");
        } 
    }

    IEnumerator SpawnEnemie()
    {
        int id;
        id = Random.Range(0, Prefab.Count); 
        GameObject enemy = Instantiate(Prefab[id]);
        CurrentEnemies.Add(enemy);
        yield return new WaitForSeconds(1.5f);
    }
}
