using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{


    public int startingHealth = 50; //sets max health
    private int currentHealth;


    private void Awake()
    {
        currentHealth = startingHealth;
    }
    public void Kill()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("DeathScene"); //loads death scene when then player is killed
    }

    public int GetHealth()
    {
        return currentHealth;
    }


    public void ChangeHealth(int changeAmount)
    {


        currentHealth = currentHealth + changeAmount; //changes players health by damage taken
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);
        if (currentHealth == 0) //checks when players health becomes 0
        {
            Kill(); //activates the kill function
        }
    }
    
}
