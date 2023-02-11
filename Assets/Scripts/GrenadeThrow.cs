using UnityEngine;

namespace DefaultNamespace
{
    public class GrenadeThrow : MonoBehaviour
    {

        [SerializeField] private float force = 100f;
        [SerializeField] private GameObject grenadePrefab;
        [SerializeField] private Transform throwPoint;
       

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                ThrowGrenade();
            }
        }

        void ThrowGrenade()
        { 
            GameObject grenade = Instantiate(grenadePrefab, transform.position, transform.rotation);
            var rigidbody = grenade.GetComponent<Rigidbody>();
            {
                rigidbody.AddForce(transform.forward * force, ForceMode.VelocityChange);
            }
        }
    }
}
    
