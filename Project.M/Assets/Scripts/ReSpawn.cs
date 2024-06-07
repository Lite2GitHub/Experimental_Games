using UnityEngine;


public class ReSpawn : MonoBehaviour
{
    bool isBumped;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isBumped = true;
            Debug.Log("bump check");
        }
    }

    public void Update()
    {
        if (isBumped)
        {
            Debug.Log("updater");
            RestartGame();
            isBumped = false;
        }
    }

    private void RestartGame()
    {
        Debug.Log("respnwnwdjnajd");
        DeathManager.instance.ResetGame();
    }

}
