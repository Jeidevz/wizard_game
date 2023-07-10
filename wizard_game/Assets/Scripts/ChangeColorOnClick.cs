using UnityEngine;
using UnityEngine.UI;
namespace wizardproject
{
    public class ChangeColorOnClick : MonoBehaviour
    {
        public KeyCode actionKey;
        public Color defaultColor;
        public Color activeColor;

        private Image img;
        // Use this for initialization
        void Start()
        {
            img = GetComponent<Image>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(actionKey))
                img.color = activeColor;
            else
                img.color = defaultColor;
        }
    }
}
