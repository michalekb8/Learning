using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    [Header("Player attributes")]
    public float MoveSpeed = 5f;


    private Rigidbody playerRB;
    private float horizontalInput;
    private float verticalInput;
    private float boundries = 49.5f;

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        playerRB.transform.position += new Vector3(0, 0, horizontalInput * Time.deltaTime * MoveSpeed);
        verticalInput = Input.GetAxis("Vertical");
        playerRB.transform.position += new Vector3(-verticalInput * Time.deltaTime * MoveSpeed, 0, 0);

        if (playerRB.transform.position.x >= boundries)
        {
            playerRB.transform.position = new Vector3(boundries, 0.5f, playerRB.transform.position.z);
        }
        if (playerRB.transform.position.x <= -boundries)
        {
            playerRB.transform.position = new Vector3(-boundries, 0.5f, playerRB.transform.position.z);
        }
        if (playerRB.transform.position.z >= boundries)
        {
            playerRB.transform.position = new Vector3(playerRB.transform.position.x, 0.5f, boundries);
        }
        if (playerRB.transform.position.z <= -boundries)
        {
            playerRB.transform.position = new Vector3(playerRB.transform.position.x, 0.5f, -boundries);
        }
    }
}
