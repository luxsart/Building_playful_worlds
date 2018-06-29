using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float acceleration = 0.3f;
    public float braking = 0.3f;
    public float steering = 4.0f;

    PlayerController _inputs;
    Rigidbody rigid;

    void Start()
    {
        _inputs = GetComponent<PlayerController>();
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // steering
        float rot = transform.localEulerAngles.z - _inputs.x * steering;
        transform.localEulerAngles = new Vector3(0.0f, rot, 0.0f);

        // acceleration/braking
        float velocity = rigid.velocity.magnitude;
        float y = _inputs.y;
        if (y > 0.01f)
        {
            velocity += y * acceleration;
        }
        else if (y < -0.01f)
        {
            velocity += y * braking;
        }
        // apply fish movement
        rigid.velocity = transform.forward * velocity;
        }
}
