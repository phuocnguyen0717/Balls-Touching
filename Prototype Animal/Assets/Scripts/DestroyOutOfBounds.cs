using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 35.0f;
    private float bottomBound = 13.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -bottomBound)
        {
            Destroy(gameObject);
        }
    }
}
