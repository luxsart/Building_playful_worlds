using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Negative_Points : MonoBehaviour {

    public AudioSource punishSound;
    public int scoreRed = 10;

    // Use this for initialization
    void Start()
    {
        punishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player1")
        {
            punishSound.Play();
            Score_ui_script.scoreValue -= scoreRed;
        }

        if (col.tag == "Player2")
        {
            punishSound.Play();
            Score_ui_script_p2.scoreValue -= scoreRed;
        }
    }
}
