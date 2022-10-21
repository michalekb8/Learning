using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject Coin;
    public float Health = 1f;
    [SerializeField] private float startHealth = 25f;
    private Vector3 coinOffset = new Vector3(0, 0.2f, 0);
    private void Start()
    {
        Health = startHealth;
    }

    private void Update()
    {
        if (Health <= 0)
        {
            Instantiate(Coin, transform.position - coinOffset, transform.rotation);
            Destroy(gameObject);
        }
    }
}
