using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    void Start()
    {
    }

    void Update()
    {
        transform.Rotate(25.0f * Time.deltaTime, 25.0f * Time.deltaTime, 0.0f);
    }
}
