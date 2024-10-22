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

    // Update is called once per frame
    void Update()
    {
        enemyRigid.AddForce((player.transform.position - transform.position).normalized * speedEnemy);
    }
}
