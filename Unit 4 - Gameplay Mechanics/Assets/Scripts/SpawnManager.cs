using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefab, new Vector3(0, 0, 6), prefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
