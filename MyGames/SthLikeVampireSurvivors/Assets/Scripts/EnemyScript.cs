using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float Health = 5f;
    private float startHealth = 5f;

    private void Start()
    {
        Health = startHealth;
    }
}
