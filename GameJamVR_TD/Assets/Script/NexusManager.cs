using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NexusManager : MonoBehaviour
{

    public float CurrentLife;
    public float MaxLife = 20;

    public bool immune = false;
    float immunityTime = 0.2f;
    float tmpTimer;


    // Start is called before the first frame update
    void Start()
    {
        CurrentLife = MaxLife;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (immune)
        {
            tmpTimer += Time.fixedDeltaTime;

            if (tmpTimer > immunityTime)
            {
                immune = false;
            }
        }

        if(CurrentLife <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!immune)
        {
            if(other.tag == "enemy")
            {
                CurrentLife -= 1;
                immune = true;
            }
        }
    }
}
