using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_ui_script : MonoBehaviour {

    public Text scoreText;
    public static int scoreValue = 0;
    

    void Start()
    {
        scoreValue = 0;
    }

    void Update () {
        scoreText.text = "Score: " + scoreValue;
	}
}
