using System;
using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float life;
    public GameObject[] Enemies;


    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
        Destroy (gameObject);
    }
}
