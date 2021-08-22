using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    float delayTime = 0;
    float spawnInterval = 2;

    void Update()
    {
        // 2 second interval to spawn dogs
        delayTime += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (delayTime >= spawnInterval)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                delayTime = 0;
            }
            else
            {
                Debug.Log("You need to wait " + (spawnInterval - delayTime) + " seconds to call another dog.");
            }
        }
    }
}
