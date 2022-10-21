using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemieManager : MonoBehaviour
{

    public List<GameObject> CurrentEnemies;
    public List<GameObject> Prefab = new List<GameObject>();
    public int enemieID;
    public bool enemieEnabled;
    private bool flag = false;

    public float score;

    public float duree = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (enemieEnabled && !flag && duree < 120f)
        {
            //InvokeRepeating("SpawnEnemie", 0f, 1.5f);
            StartCoroutine("SpawnEnemie");
        } 

        if (duree > 119f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    IEnumerator SpawnEnemie()
    {
        flag = true;
        int id;
        id = Random.Range(0, Prefab.Count); 
        GameObject enemy = Instantiate(Prefab[id], new Vector3(4.3f, 1.75f, 5.7f), Quaternion.identity);
        CurrentEnemies.Add(enemy);
        yield return new WaitForSeconds(1.5f);
        duree += 1.5f;
        flag = false;
    }

    public void LaunchWave()
    {
        enemieEnabled = true;
    }
}
