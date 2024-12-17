using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAttack : MonoBehaviour
{
    public float life;
    public EnemyHealth enemyHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        Destroy(gameObject, life);
        enemyHealth = GameObject.FindWithTag("Enemy").GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            enemyHealth.enemyCurrentHealth--;
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }
}
