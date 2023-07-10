using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArea : MonoBehaviour {
    public float width = 20;
    public float length = 20;

    private Vector3 size;
    void Start () {
	}
	
	void Update () {
		
	}

    private void OnDrawGizmosSelected()
    {
        float up = 5;
        size.x = width;
        size.y = up;
        size.z = length;
        Gizmos.DrawWireCube(transform.position + Vector3.up * up/2, size);
    }

}
