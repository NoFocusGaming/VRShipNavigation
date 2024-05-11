using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsAndInput : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 position;
    public Vector3 velocity;

    void Start()
    {
        velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();

        position = position + velocity * Time.deltaTime;
        transform.localPosition = position;
    }

    public float deltaVelocity = 10;

    void ProcessInput()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
            velocity.x -= deltaVelocity;
        if(Input.GetKey(KeyCode.RightArrow))
            velocity.x += deltaVelocity;
        
        if(Input.GetKey(KeyCode.UpArrow))
            velocity.z += deltaVelocity;
        if(Input.GetKey(KeyCode.DownArrow))
            velocity.z -= deltaVelocity;

        if(Input.GetKey(KeyCode.PageDown))
            velocity.y -= deltaVelocity;
        if(Input.GetKey(KeyCode.PageUp))
            velocity.y += deltaVelocity;

        if(Input.GetKey(KeyCode.Space))
            velocity += Vector3.zero;    
    }
}
