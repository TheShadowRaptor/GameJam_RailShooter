using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormSpawner : MonoBehaviour
{
    public GameObject[] worms; // the prefab to be spawned
    public float spawnTime = 6f; // how long between each spawn

    private void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            SpawnRandom();
        }

        if (Input.GetKeyUp(KeyCode.U))
        {

        }
    }

    // Update is called once per frame
    void SpawnRandom()
    {
        Instantiate(worms[UnityEngine.Random.Range(0, worms.Length - 1)]);
    }   
}
