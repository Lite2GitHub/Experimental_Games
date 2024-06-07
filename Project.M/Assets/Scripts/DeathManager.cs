using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
    // Reference to the GameManager instance (singleton pattern)
    // GameManager refers to death manager cause hee hee ha ha.
    public static DeathManager instance;

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        // Ensure there's only one instance of GameManager
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject); // Keep GameManager persistent between scenes
    }

    // Method to reset the game
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reload the current scene
    }
}

