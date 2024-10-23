using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speedEnemy = 3.0f;
    [SerializeField] private GameObject player;
    private Rigidbody enemyRigid;
    void Start()
    {
        enemyRigid = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }
    void Update()
    {
        MoveTowardsEnemy();
    }
    private void MoveTowardsEnemy()
    {
        Vector3 flowPlayer = (player.transform.position - transform.position).normalized;
        enemyRigid.AddForce(flowPlayer * speedEnemy);
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
