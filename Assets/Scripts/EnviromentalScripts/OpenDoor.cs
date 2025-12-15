using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    
    public string ChosenSceneName;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Entered!");
        //SceneManager.LoadScene(ChosenSceneName);
    }
}