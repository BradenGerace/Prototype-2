using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalDamage : MonoBehaviour
{
    public GameObject player;

    private int lives = 3;

    public Text livesText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroy(player);
        Debug.Log("Player hit");
        --lives;
        Debug.Log("Lives: " + lives);

        livesText.text = "Lives: " + lives;

        if (lives <= 0)
        {
            Destroy(player);
        }
    }
}
