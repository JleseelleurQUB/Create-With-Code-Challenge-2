using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        // Assigns a random value to spawnInterval variable, carries out spawn function once after this time has passed
        spawnInterval = Random.Range(3, 5);
        Invoke("SpawnRandomBall", spawnInterval);
    }

    // Function to spawn random ball at random x position at top of play area, looping
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // Instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

        // Set new random spawnInterval, repeats function once after this time has passed, creating loop
        spawnInterval = Random.Range(3, 5);
        Invoke("SpawnRandomBall", spawnInterval);
    }

}
