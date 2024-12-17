using System.Collections;
using System.Collections.Generic;
using UnityEditor.XR;
using UnityEngine;
using UnityEngine.UI;

public class SupportSpawnerSystem : MonoBehaviour
{
    public GameObject jumper;
    public GameObject hover;
    public Transform spawnr;
    public int hoverLimit;
    public int jumperLimit;
    public int supportMaxLimit;
    public bool runOut;
    public bool jumperOff;
    public bool hoverOff;
    public Text supportText;
    
    // Start is called before the first frame update
    void Start()
    {
        runOut = false;
        jumperOff = false;
        hoverOff = false;
        supportText = GameObject.Find("Supporttext").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (runOut == false)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                if (jumperOff == false)
                {
                    GameObject newJumper = Instantiate(jumper, spawnr.position, spawnr.rotation);
                    jumperLimit--;
                }
                
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                if (hoverOff == false)
                {
                    GameObject newHover = Instantiate(hover, spawnr.position, spawnr.rotation);
                    hoverLimit--;
                }
                
            }
        }
        if (jumperLimit == 0)
        {
            jumperOff = true;
        }
        if(hoverLimit == 0)
        {
            hoverOff = true;
        }
        if (jumperOff == true && hoverOff == true)
        {
            runOut = true;
        }
        supportText.GetComponent<Text>().text = supportMaxLimit.ToString();
    }
}
