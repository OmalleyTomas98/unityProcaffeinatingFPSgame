using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	//Instance Variables
	public float maxSpeed = 5f;
	public float rotSpeed = 180f;

	float playerBoundaryRadius = 0.5f;

	void Start () {
	
	}
	
	void Update () {

		// ROTATE the Player.

		// Grab our rotation quaternion
		Quaternion rot = transform.rotation;

		// Grab the Z euler angle
		float z = rot.eulerAngles.z;

		// Change the Z angle based on input
		z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

		// Recreate the quaternion
		rot = Quaternion.Euler( 0, 0, z );

		// Feed the quaternion into our rotation
		transform.rotation = rot;

		// MOVE the player.
		Vector3 pos = transform.position;
		 
		Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);

		pos += rot * velocity;

		// RESTRICT the player to the camera's boundaries!

		// First to vertical, because it's simpler
		if(pos.y+playerBoundaryRadius > Camera.main.orthographicSize) {
			pos.y = Camera.main.orthographicSize - playerBoundaryRadius;
		}
		if(pos.y-playerBoundaryRadius < -Camera.main.orthographicSize) {
			pos.y = -Camera.main.orthographicSize + playerBoundaryRadius;
		}

		// Now calculate the orthographic width based on the screen ratio
		float screenRatio = (float)Screen.width / (float)Screen.height;
		float widthOrtho = Camera.main.orthographicSize * screenRatio;

		// Now do horizontal bounds
		if(pos.x+playerBoundaryRadius > widthOrtho) {
			pos.x = widthOrtho - playerBoundaryRadius;
		}
		if(pos.x-playerBoundaryRadius < -widthOrtho) {
			pos.x = -widthOrtho + playerBoundaryRadius;
		}

		// Finally, update our position!!
		transform.position = pos;


	}


private void OnCollisionEnter2D(Collision2D other)
    {
    	//PickUp 
        if (other.gameObject.CompareTag("Coins"))
        {
        	//Destroy coin after user collided
			Destroy(other.gameObject);
        }
    }




}
