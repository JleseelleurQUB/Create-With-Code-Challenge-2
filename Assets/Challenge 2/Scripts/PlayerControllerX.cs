using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogUsed = 0f;
    private float dogCooldown = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(Time.time > dogUsed + dogCooldown) // If the current time is greater than the time of the last dog plus the cooldown, another dog is spawned
            {
                dogUsed = Time.time; // Updates the time of the last dog
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
            
        }
    }
}
