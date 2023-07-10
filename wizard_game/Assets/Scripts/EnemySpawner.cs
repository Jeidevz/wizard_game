using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace wizardproject
{
    public class EnemySpawner : MonoBehaviour
    {
        public GameObject prefab;
        public Transform target;
        public List<SpawnArea> spawnAreas;
        public int count = 100;

        // Use this for initialization
        void Start()
        {
            if (count <= 0)
                return;

            //random pos generator
            for (int i = 0; i < count; i++)
            {
                int index = Random.Range(0, spawnAreas.Count);
                SpawnArea area = spawnAreas[index];
                Vector3 areaPos = area.transform.position;
                float widthRadius = area.width / 2;
                float lengthRadius = area.length / 2;
                float posX = Random.Range(areaPos.x - widthRadius, areaPos.x + widthRadius);
                float posZ = Random.Range(areaPos.z - lengthRadius, areaPos.z + lengthRadius);
                Vector3 spawnPos;
                spawnPos.x = posX;
                spawnPos.y = 1;
                spawnPos.z = posZ;
                Instantiate(prefab, spawnPos, prefab.transform.rotation);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
