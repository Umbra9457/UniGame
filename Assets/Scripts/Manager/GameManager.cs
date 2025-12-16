using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Static reference to the single instance of the GameManager
    public static GameManager Instance { get; private set; }

    // This variable persists between scenes

    public static int enemyCount;
    public string nextSceneName;

    void Start()
    {
      
    }
    private void Awake()
    {

        Instance = this;
        DontDestroyOnLoad(this.gameObject);
       
    }
    public static void DecreaseEnemyCount()
    {
        enemyCount--;
       
        if (enemyCount <= 0)
        {
            // Find the GameManager instance to access non-static variables like nextSceneName
            GameManager manager = FindObjectOfType<GameManager>();
            if (manager != null)
            {
                SceneManager.LoadScene("WinScene"); // Load the next scene
            }
        }
    }

}