using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollowSecond : MonoBehaviour
{
    public NavMeshAgent enemy;
    public GameObject player;
    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("MainCamera");
        target = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(target.position);
    }

}
