using UnityEngine;

namespace wizardproject
{
    public class Meteorite : MonoBehaviour
    {
        public float spawnHeight = 10;
        public float speed = 1;

        void Start()
        {
            transform.position += Vector3.up * spawnHeight;
        }

        private void FixedUpdate()
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Floor")
                Destroy(gameObject);
        }
    }
}
