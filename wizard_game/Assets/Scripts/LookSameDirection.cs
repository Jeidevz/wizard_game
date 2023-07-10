using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookSameDirection : MonoBehaviour {
    public Transform target;
    public float damping;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 lookPos = target.position - transform.position;
        lookPos.y = 0;
        Quaternion rotation = Quaternion.LookRotation(lookPos);
        //transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
        transform.rotation = rotation;
    }
}
