using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace wizardproject
{
    public class ObjectToRayHitPoint : MonoBehaviour
    {
        public Transform targetTransform;
        public MeshRenderer targetRender;
        public float hitDistance = 1000;

        void Update()
        {
            int layerMask = LayerMask.GetMask("Walkable");
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, hitDistance, layerMask))
            {
                targetRender.enabled = true;
                targetTransform.position = hit.point + Vector3.up * 0.01f;
            }
            else
            {
                targetRender.enabled = false;
            }
        }
    }
}
