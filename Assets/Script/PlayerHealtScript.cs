using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealtScript : MonoBehaviour
{
    public int playerMaxHealth;
    public int playerCurrentHealth;
    public Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
        healthText = GameObject.Find("PlayerHealth").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.GetComponent<Text>().text = playerCurrentHealth.ToString();
    }
}
