using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyGrenade : MonoBehaviour
{
    public float delay = 3f;
    public GameObject explosionEffect;
    public float radius = 5f;
    public float force = 500f;

    public float countdown;
    public bool hasExploded = false;

    void Start()
    {
        countdown = delay;
    }

    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }

    void Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);

        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>(); 
            if (rb != null)
            { 
                rb.AddExplosionForce(force, transform.position, radius);  
            }
        }
        Destroy(gameObject);
    }
}
