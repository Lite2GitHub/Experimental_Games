using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectdropper : MonoBehaviour
{
    public GameObject[] objectsToSpawn; // Array of objects to spawn
    public float spawnInterval = 1f; // Time interval between spawns
    public Vector3 spawnAreaMin; // Minimum boundary of the spawn area
    public Vector3 spawnAreaMax; // Maximum boundary of the spawn area
    public float objectLifespan = 10f;

    private void Start()
    {
        // Start the spawning process
        StartCoroutine(SpawnObjects());
    }

    private IEnumerator SpawnObjects()
    {
        while (true)
        {
            // Spawn 4 random objects
            for (int i = 0; i < 4; i++)
            {
                SpawnRandomObject();
            }
            // Wait for the specified interval before spawning again
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void SpawnRandomObject()
    {
        // Randomly select an object from the array
        GameObject objectToSpawn = objectsToSpawn[Random.Range(0, objectsToSpawn.Length)];

        // Generate a random position within the spawn area
        Vector3 spawnPosition = new Vector3(
            Random.Range(spawnAreaMin.x, spawnAreaMax.x),
            Random.Range(spawnAreaMin.y, spawnAreaMax.y),
            Random.Range(spawnAreaMin.z, spawnAreaMax.z)
        );

        // Instantiate the object at the random position
        GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);

        Destroy(spawnedObject, objectLifespan);
    }
}
