using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace wizardproject
{
    [System.Serializable]
    public struct ButtonData
    {
        public KeyCode key;
        public Image img;
        public string animTriggerName;
    }
}
