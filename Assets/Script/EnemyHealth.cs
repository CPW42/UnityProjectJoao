using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyMaxHealth;
    public float enemyCurrentHealth;
    // Start is called before the first frame update
    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyCurrentHealth == 0)
        {
            Destroy(gameObject);
        }
    }
}
