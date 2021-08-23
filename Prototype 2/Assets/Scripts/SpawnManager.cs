using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 15;
    private float spawnRangeZ = 15;
    private float spawnPosZ = 20;
    Vector3 spawnRotationLeft = new Vector3 (0, 90, 0);
    Vector3 spawnRotationRight = new Vector3(0, 270, 0);

    private float startDelay = 2;
    private float spawnInterval = 3f;
    //private float spawnIncrease = 0.05f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Vector3 spawnPosLeft = new Vector3(-20, 0, Random.Range(1, spawnRangeZ));
        Vector3 spawnPosRight = new Vector3(20, 0, Random.Range(1, spawnRangeZ));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int animalIndex2 = Random.Range(0, animalPrefabs.Length);
        int animalIndex3 = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        Instantiate(animalPrefabs[animalIndex2], spawnPosLeft, Quaternion.Euler(spawnRotationLeft));
        Instantiate(animalPrefabs[animalIndex3], spawnPosRight, Quaternion.Euler(spawnRotationRight));
    }
}
