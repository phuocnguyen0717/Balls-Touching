using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawnPrefabs;
    private float spawnBound = 9.0f;
    void Start()
    {

        Instantiate(spawnPrefabs, GenerateSpawnPosition(), spawnPrefabs.transform.rotation);
    }

    void Update()
    {

    }
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnBound, spawnBound);
        float spawnPosZ = Random.Range(-spawnBound, spawnBound);

        Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return spawnPos;
    }
}
