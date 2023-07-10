using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace wizardproject
{
    public class CharacterAnimationManager : MonoBehaviour
    {
        public Animator anim;
        [Space]
        [Header("Button Setting")]
        public Color activeColor;
        public Color defaultColor;
        public List<ButtonData> buttons;

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            checkButtons(buttons);
        }

        void checkButtons(List<ButtonData> buttons)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                ButtonData button = buttons[i];
                executeAnimationOnPress(button);
                changeButtonColorOnHeld(button);
            }
        }

        bool doesButtonHaveImage(ButtonData button)
        {
            if (button.img != null)
                return true;

            return false;
        }

        bool isButtonKeyBeingHeld(ButtonData button)
        {
            if (Input.GetKey(button.key))
                return true;

            return false;
        }

        void executeAnimation(string animTriggerName)
        {
            anim.SetTrigger(animTriggerName);
        }

        void executeAnimationOnPress(ButtonData button)
        {
            if (Input.GetKeyDown(button.key) && !isAnyAnimationIsRunning())
            {
                executeAnimation(button.animTriggerName);
            }
        }

        void changeButtonColorOnHeld(ButtonData button)
        {
            if (button.img != null)
            {
                button.img.color = (Input.GetKey(button.key)) ? activeColor : defaultColor;
            }
        }

        bool isAnyAnimationIsRunning()
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
                return false;

            return true;
        }
    }
}
