using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 18;
    private float spawnPosZ = 10;

    private float startDealy = 2f;
    private float spawnInterval = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("SpawnRandomAnimal", startDealy, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal(){
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3 (Random.Range(-spawnRangeX,spawnRangeX), 0, spawnPosZ);

        Instantiate (animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
