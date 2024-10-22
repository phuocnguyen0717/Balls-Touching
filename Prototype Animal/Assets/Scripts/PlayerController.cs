using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 20.0f;
    private float horizontalInput;
    private float xRange = 10.0f;
    [SerializeField] private GameObject projectilePrefabs;
    void Start()
    {
    }
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKey(KeyCode.Space))
        {
            Instantiate(projectilePrefabs, transform.position, transform.rotation);
        }
    }
}
