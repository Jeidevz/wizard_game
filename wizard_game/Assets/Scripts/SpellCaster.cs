using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace wizardproject
{
    public class SpellCaster : MonoBehaviour
    {
        public Transform castCircle;
        public List<SpellData> spells;

        private Transform cam;
        void Start()
        {
            cam = GameObject.FindGameObjectWithTag("MainCamera").transform;
        }

        void Update()
        {
            checkSpells(spells);
        }

        void checkSpells(List<SpellData> spells)
        {
            for (int i = 0; i < spells.Count; i++)
            {
                if (Input.GetKeyDown(spells[i].castKeyCode))
                    castSpell(spells[i]);
            }
        }

        void castSpell(SpellData data)
        {
            //RaycastHit hit;
            //if (Physics.Raycast(cam.position, cam.forward, out hit, 1000))
            //{
            //    Instantiate(data.spell, hit.point, data.spell.transform.rotation);
            //    Debug.Log(hit.point);
            //}
            Instantiate(data.spell, castCircle.position, data.spell.transform.rotation);
        }
    }
}
