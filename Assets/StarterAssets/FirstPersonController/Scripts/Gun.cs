using System.Collections;
using System.Collections.Generic;   
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform BulletSpawn;
    public GameObject BulletPrefab;
    public float BulletSpeed;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var bullet = Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation);
            bullet.GetComponent<Rigidbody>().linearVelocity = BulletSpawn.forward * BulletSpeed;
        }
    }
}
