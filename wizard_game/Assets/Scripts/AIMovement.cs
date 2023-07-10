using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace wizardproject
{
    public class AIMovement : MonoBehaviour
    {
        public Transform target;
        [SerializeField]
        private Animator anim;
        private NavMeshAgent agent;
        // Use this for initialization
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            agent.updatePosition = false;
            anim = GetComponent<Animator>();

            if (target == null)
            {
                Transform findTarget  = GameObject.FindGameObjectWithTag("Tower").transform;
                if (findTarget)
                    target = findTarget;
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (target)
            {
                agent.SetDestination(target.position);
                //if (agent.isStopped)
                //    anim.SetBool("isWalking", false);
                //else
                //    anim.SetBool("isWalking", true);

                agent.nextPosition = transform.position;
            }
        }
    }
}
