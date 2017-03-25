using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Camera mainCam;
    public GameObject asteroid;             // The enemy prefab to be spawned.
    public GameObject addFuel;
    public float spawnTimeAsteroid = 1f;    // How long between each spawn.
    public float spawnTimeFuel = 3f;
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.


    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("SpawnAsteroid", 2f, spawnTimeAsteroid);

        InvokeRepeating("SpawnFuel", 4.625f, spawnTimeFuel);

        float offset = -4;
        foreach (Transform spawnpoint in spawnPoints)
        {
            spawnpoint.position = new Vector3(mainCam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 2f, offset, 0f);
            offset += 2;
        }
    }

    void SpawnAsteroid()
    {
        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(asteroid, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }

    void SpawnFuel()
    {
        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(addFuel, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
