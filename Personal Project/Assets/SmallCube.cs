using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCube : MonoBehaviour
{
    public Vector3 endPosition;
    private Vector3 startPosition;
    private bool isMoving = false;
    private bool isRotating = false;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        Invoke("InitTranslation", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
            transform.Translate(endPosition * Time.deltaTime);
        if (isRotating)
            transform.Rotate(-30.0f * Time.deltaTime, -30f * Time.deltaTime, -25f * Time.deltaTime);


    }

    private void InitTranslation()
    {
        isMoving = true;
        Invoke("DisableTranslation", 3f);

    }

    private void DisableTranslation()
    {
        isMoving = false;
        isRotating = true;
    }

}
