using UnityEngine;
using System.Collections;


namespace wizardproject
{
    // Applies an explosion force to all nearby rigidbodies
    [RequireComponent(typeof(SphereCollider))]
    public class ExplodeForce : MonoBehaviour
    {
        public float radius = 5f;
        public float power = 10f;
        public float timer = 2f;

        public SphereCollider sphereCollider;

        void Start()
        {
            sphereCollider = GetComponent<SphereCollider>();
            sphereCollider.isTrigger = true;
            sphereCollider.radius = radius;
            Invoke("explode", timer);
        }

        void explode()
        {
            sphereCollider.isTrigger = false;
            Vector3 explosionPos = transform.position;
            Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();

                if (rb != null)
                    rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
            }

            Invoke("DestroySelf", .1f);
        }

        void DestroySelf()
        {
            Destroy(gameObject);
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, radius);
        }
    }
}
