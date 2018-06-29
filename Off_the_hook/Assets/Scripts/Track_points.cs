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

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hitbox_points")
        {
            rewardSound.Play();
        }
    }
}