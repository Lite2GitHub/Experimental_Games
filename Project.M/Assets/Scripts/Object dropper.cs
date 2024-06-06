using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectdropper : MonoBehaviour
{
    public GameObject[] spawner;    // Array for objects to live in
    public float minSpawnInterval = 1f;
    public float maxSpawnInterval = 5f;

    public int minObjsToSpawn = 1;
    public int maxObjsToSpawn = 4;

    private void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    private IEnumerator SpawnObjects()
    {
        while (true)
        {
            float spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);

            // wait for next spawn
            yield return new WaitForSeconds(spawnInterval);
        
            int objsToSpawnCount = Random.Range(minObjsToSpawn, maxObjsToSpawn);
            
            for (int i = 0; i < objsToSpawnCount; i++)
            {
                // Randomizer
                int objectIndex = Random.Range(0, minObjsToSpawn.Length);

                Instantiate(spawner[objectIndex], transform.position, Quaternion.identity);
            }
        }
    }

}
