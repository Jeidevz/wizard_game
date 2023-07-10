using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace wizardproject
{

    public class CharacterController : MonoBehaviour
    {
        public Animator anim;

        private void Start()
        {
            if (!anim)
                anim = GetComponent<Animator>();
        }

        void Update()
        {
            triggerAnim(KeyCode.Mouse0, "BasicAttack");
            triggerAnim(KeyCode.Q, "SpecialAttack1");
            triggerAnim(KeyCode.W, "SpecialAttack2");
            triggerAnim(KeyCode.E, "SpecialAttack2");
            triggerAnim(KeyCode.R, "Ultimate");
        }

        void triggerAnim(KeyCode key, string parameter)
        {
            if (Input.GetKeyDown(key))
                anim.SetTrigger(parameter);
        }
    }
}
