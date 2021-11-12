using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDustCloud : MonoBehaviour
{
    public GameObject[] dustPrefabs;
    private float spawnRangeX = 10;
    private float spawnRangeY = 10;
    private float startDelay = 2;
    public float spawnInterval = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomDust", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomDust() {
        // Randomize animal index and spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 20, 2);
        int index = Random.Range(0, dustPrefabs.Length);
        Instantiate(dustPrefabs[index], spawnPos, dustPrefabs[index].transform.rotation);
    }
}
