using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawningSystem : MonoBehaviour
{
    public GameObject walkingEnemy;
    public float enemyTimer;
    public bool spawnAllowed = false;
    public int limit;
    public int setLimit;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawning());
    }

    // Update is called once per frame
    void Update()
    {
        if (limit == setLimit)
        {
            spawnAllowed = false;
        }

    }

    private IEnumerator spawning()
    {
        WaitForSeconds wait = new WaitForSeconds(enemyTimer);
        while(spawnAllowed == true && limit < setLimit)
        {
            yield return wait;
            GameObject newEnemy = Instantiate(walkingEnemy, new Vector3(Random.Range(-5f, 5f),0, Random.Range(-5f,5f)), Quaternion.identity);
            limit++;
        }
    }
}
