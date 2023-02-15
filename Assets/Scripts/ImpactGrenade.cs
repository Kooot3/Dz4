﻿using System;
using UnityEngine;

namespace DefaultNamespace

 {
     public class ImpactGrenade : MonoBehaviour
     {
         [SerializeField] private float radius = 5f;
         [SerializeField] private float explosionForce = 700f;
         [SerializeField] private GameObject explosionEffect;

         private void OnCollisionEnter(Collision collision)
         {
             Explode();
         }

         void Explode()
         {
             var explosionEffectInstance = Instantiate(explosionEffect, transform.position, transform.rotation);
             Destroy(explosionEffectInstance, 2f);

             Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

             foreach (Collider nearbyObject in colliders)
             {
                 Rigidbody rigidbody = nearbyObject.GetComponent<Rigidbody>();
                 if (rigidbody != null)
                 {
                     rigidbody.AddExplosionForce(explosionForce, transform.position, radius);
                 }
             }

             Destroy(gameObject);
         }


         private double GetSomething()
         {
             return 42d;
         }
     }
 }