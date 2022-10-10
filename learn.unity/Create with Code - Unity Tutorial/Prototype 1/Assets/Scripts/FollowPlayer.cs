using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset1 = new Vector3(0, 5, -7);
    private Vector3 offset2 = new Vector3(0, 2, 1.75f);
    private int camera = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.V))
            camera *= -1;


        if (camera == 1)
        {
            //Offset the camera behind the player by adding to the player's position
            transform.position = player.transform.position + offset1;
        }
        if (camera == -1)
        {
            //Offset the camera perspective of the driver’s seat.
            transform.position = player.transform.position + offset2;
        }
    }


}
