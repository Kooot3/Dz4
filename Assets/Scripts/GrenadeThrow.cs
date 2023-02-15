using UnityEngine;

namespace DefaultNamespace
{
    public class GrenadeThrow : MonoBehaviour
    {

        [SerializeField] private float throwForce = 100f;
        [SerializeField] private GameObject grenadePrefab;

       private void Update()
        {
            if (Input.GetMouseButtonDown(1))
            {
                GrenadeThrowForward();
            }
        }

        private void GrenadeThrowForward()
        {
            GameObject grenade = Instantiate(grenadePrefab, transform.position, transform.rotation);
            Rigidbody rb = grenade.GetComponent < Rigidbody>();
            rb.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
        }
    }
}
    
