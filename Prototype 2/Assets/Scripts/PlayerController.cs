using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;

    public float speed = 10f;

    public float xRange = 12f;
    public float zRangeBottom = 0f;
    public float zRangeTop = 15f;

    float delayTime = 0f;
    float shootInterval = .2f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);

        // keeps the player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < zRangeBottom)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeBottom);
        }

        if (transform.position.z > zRangeTop)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeTop);
        }

        delayTime += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (delayTime >= shootInterval)
            {
                Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
                delayTime = 0;
            }
            else
            {
                // Debug.Log("You need to wait " + (shootInterval - delayTime) + " seconds to shoot.");
            }

            
        }
    }
}
