using UnityEngine;

public class Spell : MonoBehaviour {
    private SphereCollider sphereCollider;
    public virtual void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();
    }

    public virtual void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
