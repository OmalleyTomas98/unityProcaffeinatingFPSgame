using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Score : MonoBehaviour
{

	public static  int scoreValue = 0;
    //Varibales definition
     Text score;
    

    // Update is called once per frame
    void start()
    {
        //Creates score component in game
    	score = GetComponent<Text> ();
    }
    void Update()
    {
        //Update user score in real time
    	score.text = "Your Score:" + scoreValue;
    }
}
