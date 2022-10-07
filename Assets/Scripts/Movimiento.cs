using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Movimiento : MonoBehaviour
{
    
    public CharacterController controller;
    public float speed = 5f;
    public float gravity = -9.8f;
 

    Vector3 velocity;
    bool isGrounded;

    void Start()
    {
        
    }

    void Update()
    {

        //OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, controller);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move*speed*Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity*Time.deltaTime);
    }
}
