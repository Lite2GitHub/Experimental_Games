using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    public GameObject spawnPoint;
    //public GameObject playerPrefab;
    bool isBumped;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
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
            RespawnPlayer();
            isBumped = false;
        }
    }

    private void RespawnPlayer()
    {
        
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        player.transform.position = spawnPoint.transform.position;
        
        

        Debug.Log("respnwnwdjnajd");
    }

}
