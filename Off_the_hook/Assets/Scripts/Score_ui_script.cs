using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_ui_script : MonoBehaviour {

    public Text scoreText;
    public static int scoreValue = 0;
    Text score;

    private void Start()
    {
        score = GetComponent<Text>();
    }

    void Update () {
        scoreText.text = "Score: " + scoreValue;
	}
}
