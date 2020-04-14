using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    
	public static  int scoreValue = 0;
     Text score;
    

    // Update is called once per frame
    void start()
    {
    	score = GetComponent<Text> ();
    }
    void Update()
    {
    	score.text = "Your Score:" + scoreValue;
    }
}
