using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    private PlayerMovement playerMovementScript;
    public Text healthText;
    
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerMovementScript = player.GetComponent<PlayerMovement>();
    }

    void Update()
    {
        healthText.text = "Health: " + playerMovementScript.playerStats.health;
    }
}
