using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float sendDelay = 0.5f;
    private float uptime;
    // Update is called once per frame
    void Update()
    {
        uptime += Time.deltaTime;
        // On spacebar press, send dog

        if (Input.GetKeyDown(KeyCode.Space) && uptime >= sendDelay)
        {
            uptime = 0.0f;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }

    }
}
