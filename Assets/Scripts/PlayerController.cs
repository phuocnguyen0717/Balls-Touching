using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigid;
    public GameObject focalPoint;
    private float playerSpeed = 10.0f;
    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");

        playerRigid.AddForce(focalPoint.transform.forward * forwardInput * playerSpeed);
    }
}
