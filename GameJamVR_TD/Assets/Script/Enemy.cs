using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemyLife = 100;
    public GameObject[] EneMana;
    public GameObject EnemyManag;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyManag == null)
        {
            EnemyManag = GameObject.FindGameObjectWithTag("EnemyManager");           
        }

        if (enemyLife <= 0)
        {
            EnemyManag.GetComponent<EnemieManager>().score += 30;
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "saw")
        {
            enemyLife -= 5;
        }
    }
}
