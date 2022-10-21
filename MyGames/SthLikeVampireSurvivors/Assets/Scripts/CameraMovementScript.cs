using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{
    public GameObject PlayerGO;
    private Transform CameraTr;
    void Start()
    {
        CameraTr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        CameraTr.transform.position = new Vector3(PlayerGO.transform.position.x + 7, PlayerGO.transform.position.y + 10.5f, PlayerGO.transform.position.z);
    }
}
