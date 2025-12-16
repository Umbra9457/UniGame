using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public int startingHealth = 10; //sets enemies health
    private int currentHealth;


    private void Awake()
    {
        currentHealth = startingHealth;
    }
    public void Kill()
    {
        Destroy(gameObject); //destroys enemy when called

    }

    public int GetHealth()
    {
        return currentHealth;
    }


    public void ChangeHealth(int changeAmount)
    {


        currentHealth = currentHealth + changeAmount; //changes health by damage taken
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);
        if (currentHealth == 0)
        {
            Kill(); //calls te kill function
        }
    }
    
}
