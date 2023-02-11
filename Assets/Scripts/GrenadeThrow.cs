using UnityEngine;

namespace DefaultNamespace
{
    public class GrenadeThrow : MonoBehaviour
    {

        public float force = 100f;
        public GameObject grenadePrefab;

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                ThrowGrenade();
            }
        }

        void ThrowGrenade()
        {
            GameObject grenade = Instantiate(grenadePrefab, transform.position, transform.rotation);
            Rigidbody rb = grenade.GetComponent < Rigidbody>();
            rb.AddForce(transform.forward * force, ForceMode.VelocityChange);
        }
    }
}
    
