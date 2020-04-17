using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class PlayerSpawner : MonoBehaviour {

	//Object references 
	public GameObject playerPrefab;
	GameObject playerInstance;

	//Number of lives player has
	public int numLives = 4;

	float respawnTimer;

	// Use this for initialization
	void Start () {
		//Call Spawn Method at start
		SpawnPlayer();
	}

	//Set player after spawn into scene
	void SpawnPlayer() {
		numLives--;
		respawnTimer = 1;
		playerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		if(playerInstance == null && numLives > 0) {
			respawnTimer -= Time.deltaTime;

			if(respawnTimer <= 0) {
				//Method called after timer to sopawbn 
				SpawnPlayer();
			}
		}
	}

	void OnGUI() {
		if(numLives > 0 || playerInstance!= null) {
			//Disiplay to scene ,  number of lives 
			GUI.Label( new Rect(0, 0, 100, 50), "Lives Left: " + numLives);
		}
		else {
			//After final death display in scene
			GUI.Label( new Rect( Screen.width/2 - 50 , Screen.height/2 - 25, 100, 50), "Game Over, Press Esc!");
			//Load new scene after complete
			SceneManager.LoadScene("Level2");
		}
	}
}
