using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track_points : MonoBehaviour
{

    public AudioSource rewardSound;
    public int scoreAdd = 10;

    // Use this for initialization
    void Start()
    {
        rewardSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player1")
        {
            rewardSound.Play();
            Score_ui_script.scoreValue += scoreAdd;
        }

        if(col.tag == "Player2")
        {
            rewardSound.Play();
            Score_ui_script_p2.scoreValue += scoreAdd;
        }
    }
}