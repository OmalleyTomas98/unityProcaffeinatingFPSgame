using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	//Instance Variable holds Players speed
	public float maxSpeed = 5f;

	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		
		Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0);
		
		pos += transform.rotation * velocity;
		//Update player posiiton
		transform.position = pos;
	}
}
