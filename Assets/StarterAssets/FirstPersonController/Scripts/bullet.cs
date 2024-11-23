using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float life;
    public GameObject[] Enemies;
    public GameObject OnHitEffect;
    public float Damage = 30f;


    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameObject CollisionVFX = Instantiate(OnHitEffect, transform.position, transform.rotation);
            Destroy(CollisionVFX, 3f);
        }
        Destroy (gameObject);
    }
}
