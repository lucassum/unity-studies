using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefab;
    private float spawnRange = 9;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefab, GenerateSpawnPosition(), prefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnX = Random.Range(-spawnRange, spawnRange);
        float spawnZ = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPos = new Vector3(spawnX, 0, spawnZ);
        return spawnPos;
    }
}
