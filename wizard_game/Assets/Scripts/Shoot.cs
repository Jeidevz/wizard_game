using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject bulletPrefab;
    public Transform spawnPoint;
    public float force = 10;
    public Transform direction;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject spawnBullet = Instantiate(bulletPrefab, spawnPoint.position, bulletPrefab.transform.rotation);
            spawnBullet.GetComponent<Rigidbody>().AddForce(direction.forward * force);
        }
	}
}
