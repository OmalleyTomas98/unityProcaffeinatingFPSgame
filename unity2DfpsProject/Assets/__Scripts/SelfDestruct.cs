using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {

//Variable definition
	public float timer = 1f;

	void Update () {
		timer -= Time.deltaTime;

	//After timer met enemies objects are destroyed out of scene
		if(timer <= 0) {
			//Destroy game obnject afetr time reaches point
			Destroy(gameObject);
		}
	}
}
