using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Static reference to the single instance of the GameManager
    public static GameManager Instance { get; private set; }

    // This variable persists between scenes
    private string nextSpawnID = "";

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(this.gameObject);
        Debug.Log("GameManager is alive and persistent."); // Add this line
    }

    // Method for other scripts to call to set the next spawn point
    public void SetNextSpawnID(string id)
    {
        nextSpawnID = id;
    }

    // Method for other scripts to call to retrieve the next spawn point
    public string GetNextSpawnID()
    {
        return nextSpawnID;
    }
}