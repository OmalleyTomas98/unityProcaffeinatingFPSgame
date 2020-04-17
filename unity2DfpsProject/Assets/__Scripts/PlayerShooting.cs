using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

	//Bullet object reference
	public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);

	public GameObject bulletPrefab;

	//Instance Variables
	int bulletLayer;

	public float fireDelay = 0.25f;
	float cooldownTimer = 0;

	void Start() {
		bulletLayer = gameObject.layer;
	}

	// Update is called once per frame
	void Update () {
		cooldownTimer -= Time.deltaTime;

		if( Input.GetButton("Fire1") && cooldownTimer <= 0 ) {
			//Shoots bullet when spacebar is pressed
			cooldownTimer = fireDelay;

			Vector3 offset = transform.rotation * bulletOffset;

			GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
			bulletGO.layer = bulletLayer;
		}
	}
}
