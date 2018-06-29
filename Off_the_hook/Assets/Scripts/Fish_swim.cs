using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_swim : MonoBehaviour
{
    public float acceleration = 0.1f;
    Rigidbody rigid_f;


    void Start()
    {
        rigid_f = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float velocity = rigid_f.velocity.magnitude;
        this.transform.Rotate(new Vector3(0, Random.value,0));
        velocity += 0.001f * acceleration;
        rigid_f.velocity = transform.forward * velocity;
    }

}
