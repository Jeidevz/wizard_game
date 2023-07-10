using UnityEngine;

namespace wizardproject
{
    public class DestroyAfterDelay : MonoBehaviour
    {
        public float delay;
        // Use this for initialization
        void Start()
        {
            Destroy(gameObject, delay);
        }
    }
}
