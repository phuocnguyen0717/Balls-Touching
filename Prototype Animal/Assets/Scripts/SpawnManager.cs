using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            float spawnRangZ = 20.0f;
            float spawnRangeX = 22.0f;
            float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
            Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnRangZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
