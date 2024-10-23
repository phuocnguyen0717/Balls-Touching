using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigid;
    public GameObject focalPoint;
    public GameObject powerUpIndicator;
    private float playerSpeed = 5.0f;
    private float powerUpStrength = 15.0f;
    public bool hasPowerUp = false;
    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    void Update()
    {
        MoveTowardsPlayer();
    }
    private void OnTriggerEnter(Collider other)
    {
        ActivatePowerUp(other);
    }
    private void OnCollisionEnter(Collision collision)
    {
        KnockBackEnemy(collision);
    }
    IEnumerator PowerUpCountDownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerUp = false;
        powerUpIndicator.gameObject.SetActive(false);
    }
    private void MoveTowardsPlayer()
    {
        float forwardInput = Input.GetAxis("Vertical");

        playerRigid.AddForce(focalPoint.transform.forward * forwardInput * playerSpeed);
        powerUpIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
    }
    private void ActivatePowerUp(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            powerUpIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(PowerUpCountDownRoutine());
        }
    }
    private void KnockBackEnemy(Collision collision)
    {
        if (hasPowerUp && collision.gameObject.CompareTag("Enemy"))
        {
            Rigidbody enemyRigid = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;
            enemyRigid.AddForce(awayFromPlayer * powerUpStrength, ForceMode.Impulse);
        }
    }
}
