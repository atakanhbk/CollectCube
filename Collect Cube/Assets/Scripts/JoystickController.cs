using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickController : MonoBehaviour
{
    public DynamicJoystick dynamicJoystick;
    public float speed;
    public float turnSpeed;
    Rigidbody rb;
    Vector3 direction;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
       
            JoystickMovement();
     
      
    }

    public void JoystickMovement()
    {
        float horizontal = dynamicJoystick.Horizontal;
        float vertical = dynamicJoystick.Vertical;

        Vector3 addedPos = new Vector3(horizontal * speed , 0, vertical * speed);
        rb.velocity = addedPos;
        //transform.position += addedPos;


         direction = Input.GetMouseButton(0) ? Vector3.forward * vertical + Vector3.right * horizontal : direction;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), turnSpeed * Time.deltaTime);
    }
}
