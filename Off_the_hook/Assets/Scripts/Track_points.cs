using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track_points : MonoBehaviour
{

    public AudioSource rewardSound;

    // Use this for initialization
    void Start()
    {
        rewardSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter()
    {
        if (gameObject.tag == "Player1")
        {
            rewardSound.Play();
            Score_ui_script.scoreValue += 10;
        }

        if(gameObject.tag == "Player2")
        {
            rewardSound.Play();
            Score_ui_script_p2.scoreValue += 10;
        }
    }
}