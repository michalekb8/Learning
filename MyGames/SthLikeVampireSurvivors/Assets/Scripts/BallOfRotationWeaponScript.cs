using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOfRotationWeaponScript : WeaponScript
{
    [Header("Rotate properties")]
    public float RotationSpeed = 1;
    public float CircleRadius = 1;
    public float ElevationOffset = 0;

    public EnemyScript EnemyScript;
    private GameObject enemyGO;
    private Transform playerTr;
    private Vector3 positionOffset;
    private float angle;
    private void Start()
    {
        playerTr = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //enemyscript = collision.gameobject.getcomponent<enemyscript>();
            Debug.Log("collision entered");
            EnemyScript.Health -= Damage;
            Debug.Log(EnemyScript.Health);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            EnemyScript.Health -= Damage;
            Debug.Log(EnemyScript.Health);
        }
    }

    private void LateUpdate()
    {
        positionOffset.Set(Mathf.Cos(angle) * CircleRadius, ElevationOffset, Mathf.Sin(angle) * CircleRadius);
        transform.position = playerTr.position + positionOffset;
        angle += Time.deltaTime * RotationSpeed;
    }
}
