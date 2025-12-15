using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PauseMenu : MonoBehaviour
{

    public GameObject PausePanel;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("1"))
        {
            Pause();

        }

        if (Input.GetKey("2"))
        {
        
                Continue();
            
        }

        
    }


    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1; 
    }

}
