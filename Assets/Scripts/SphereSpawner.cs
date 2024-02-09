using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    public GameObject spherePrefab; // The thing thats gonna spawn
    private float spawnRate = 2f;
    private float nextSpawnTime = 0f;

    private void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnSphere();
            nextSpawnTime = Time.time + spawnRate; // Call every 2 seconds
        }
    }

    private void SpawnSphere()
    {
        GameObject sphere = Instantiate(spherePrefab, transform.position, Quaternion.identity); // Create the object
        Destroy(sphere, 5f); // Destroy it so no lag
    }
}
