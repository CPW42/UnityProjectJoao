using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportSpawnerSystem : MonoBehaviour
{
    public GameObject jumper;
    public GameObject hover;
    public Transform spawnr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject newJumper = Instantiate(jumper,spawnr.position, spawnr.rotation);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            GameObject newHover = Instantiate(hover, spawnr.position, spawnr.rotation);
        }
    }
}
