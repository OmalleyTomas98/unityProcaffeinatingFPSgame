using UnityEngine;
using System.Collections;

public class DamageHandler : MonoBehaviour {

	//Variables definition
	public int health = 1;
	public float invulnPeriod = 0;
	float invulnTimer = 0;
	int correctLayer;

	SpriteRenderer spriteRend;

	void Start() {
		correctLayer = gameObject.layer;

		//Find sprite enemy child
		spriteRend = GetComponent<SpriteRenderer>();

		if(spriteRend == null) {
			spriteRend = transform.GetComponentInChildren<SpriteRenderer>();

			if(spriteRend==null) {
				Debug.LogError("Object '"+gameObject.name+"' has no sprite renderer.");
			}
		}
	}

	void OnTriggerEnter2D( ) {

		//On collision health decreases
		health--;

		if(invulnPeriod > 0) {
			invulnTimer = invulnPeriod;
			gameObject.layer = 10;
		}
	}

	void Update() {

		//Create period of invulnerability after player hit
		if(invulnTimer > 0) {
			invulnTimer -= Time.deltaTime;

			if(invulnTimer <= 0) {
				gameObject.layer = correctLayer;
				if(spriteRend != null) {
					spriteRend.enabled = true;
				}
			}
			else {
				if(spriteRend != null) {
					spriteRend.enabled = !spriteRend.enabled;
				}
			}
		}
		//Calls die function when the player as 0 ives
		if(health <= 0) {
			Die();
		}
	}
	//Destoys all objects
	void Die() {
		Destroy(gameObject);
	}

}
