using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour
{
    public float Speed = 1f;

    private Rigidbody rb;
    private Transform target;
    private Vector3 moveDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Vector3 lookAt = new Vector3(target.position.x, transform.position.y, target.position.z);
        transform.LookAt(lookAt);
        moveDirection = direction;
        rb.velocity = moveDirection * Speed * Time.deltaTime;

    }
}
