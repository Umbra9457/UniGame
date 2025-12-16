
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{

    Slider healthBar;

    PlayerHealth player;



    // Start is called before the first frame update
    //sets the slider to the player max health
    void Start()
    {
        healthBar = GetComponent<Slider>();

        player = FindAnyObjectByType<PlayerHealth>();
    }

    // Update is called once per frame
    //updates the slider when ever the players health changes
    void Update()
    {
        float currentHealth = player.GetHealth();
        float maxHealth = player.startingHealth;

        healthBar.value = currentHealth / maxHealth;
    }
}
