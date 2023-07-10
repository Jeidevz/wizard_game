using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace wizardproject
{
    public class EnableColliders : MonoBehaviour {

        public List<Collider> colliders;
        // Use this for initialization
        void Start()
        {
            getColliderFromChild(transform);
            changeEnableStateOfCollider(false);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                disableCharacterToRagdoll();
            }
        }

        void changeEnableStateOfCollider(bool state)
        {
            for (int i = 0; i < colliders.Count; i++)
            {
                colliders[i].enabled = state;
                colliders[i].GetComponent<Rigidbody>().isKinematic = !state;
            }
        }

        void getColliderFromChild(Transform target)
        {
            foreach (Transform child in target)
            {
                Collider collider = child.GetComponent<Collider>();
                if (collider)
                    colliders.Add(collider);

                getColliderFromChild(child);
            }
        }

        private void OnGUI()
        {
            GUI.Label(new Rect(0, 60, 200, 20), "Childs : " + colliders.Count);
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Spell")
            {
                disableCharacterToRagdoll();
            }
        }

        void disableCharacterToRagdoll()
        {
            changeEnableStateOfCollider(true);
            //anim.enabled = false;
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            AIMovement aiMov = GetComponent<AIMovement>();
            Animator anim = GetComponent<Animator>();
            Collider coll = GetComponent<Collider>();
            Rigidbody rg = GetComponent<Rigidbody>();
            Destroy(rg);
            Destroy(agent);
            Destroy(aiMov);
            Destroy(anim);
            Destroy(coll);
        }
    }
}
