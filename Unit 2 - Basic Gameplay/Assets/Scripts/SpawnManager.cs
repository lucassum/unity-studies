using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] gameObjects;
    public float xRange = 20f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", 2, 1.5f);

    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimals()
    {
        int randomValue = Random.Range(0, gameObjects.Length);
        float randomXPosition = Random.Range(-xRange, xRange);
        GameObject prefab = gameObjects[randomValue];
        Instantiate(prefab, new Vector3(randomXPosition, transform.position.y, transform.position.z), prefab.transform.rotation);
    }
}
