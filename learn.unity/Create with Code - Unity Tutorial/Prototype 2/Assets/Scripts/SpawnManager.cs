using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject player;
    private Vector3 playerSpawn = new Vector3(0, 0, 0);
    private float spawnRangeX = 20;
    private float spawnMinZ = -1.5f;
    private float spawnMaxZ = 16.0f;
    private float spawnPosZ = 20;
    private float spawnPosXRight = 24;
    private float spawnPosXLeft = -24;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;
    private int direction;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RollDirection", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            Instantiate(player, playerSpawn, player.transform.rotation);
        }
    }

    void SpawnRandomAnimalTop()
    {
        // Randomly generates animal index and spawn positions
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalRight()
    {
        // Randomly generates animal index and spawn positions
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosXRight, 0, Random.Range(spawnMinZ, spawnMaxZ));

        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, -90, 0));
    }

    void SpawnRandomAnimalLeft()
    {
        // Randomly generates animal index and spawn positions
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosXLeft, 0, Random.Range(spawnMinZ, spawnMaxZ));

        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 90, 0));
    }

    void RollDirection()
    {
        direction = Random.Range(1, 4);

        switch (direction)
        {
            case 1:
                SpawnRandomAnimalTop();
                break;
            case 2:
                SpawnRandomAnimalRight();
                break;
            case 3:
                SpawnRandomAnimalLeft();
                break;
        }
    }
}
