using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackScript : MonoBehaviour
{
    public GameObject attack;
    public float attackSpeed;
    public float attackTime;
    public float attackStart;
    public float attackWait;
    public Transform attackSpawning;
    public Transform player;
    public Vector3 playerLocation;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Attacker", attackStart, attackWait);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
    }
    private void Attacker()
    {
        var shoot = Instantiate(attack,attackSpawning.position, attackSpawning.rotation);
        shoot.GetComponent<Rigidbody>().velocity = attackSpawning.forward * attackSpeed;
    }
}
