using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOfRotationWeaponScript : WeaponScript
{
    private Transform playerTr;
    public float RotationSpeed = 1;
    public float CircleRadius = 1;
    public float ElevationOffset = 0;

    private Vector3 positionOffset;
    private float angle;
    private void Start()
    {
        playerTr = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void LateUpdate()
    {
        positionOffset.Set(Mathf.Cos(angle) * CircleRadius, ElevationOffset, Mathf.Sin(angle) * CircleRadius);
        transform.position = playerTr.position + positionOffset;
        angle += Time.deltaTime * RotationSpeed;
    }
}
