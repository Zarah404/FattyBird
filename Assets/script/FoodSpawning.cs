using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawning : MonoBehaviour
{
 
    public GameObject[] foodPrefabs;
    public float spawnDelay = 2f;
    public float spawnRadius = 5f;

    private float spawnTimer = 0f;

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnDelay)
        {
            spawnTimer = 0f;
            SpawnFood();
        }
    }

    private void SpawnFood()
    {
        Vector2 spawnPosition = (Vector2)transform.position + Random.insideUnitCircle.normalized * spawnRadius;
        GameObject foodPrefab = foodPrefabs[Random.Range(0, foodPrefabs.Length)];
        Instantiate(foodPrefab, spawnPosition, Quaternion.identity);
    }
    
}
