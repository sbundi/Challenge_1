using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardIinput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this is where we get the player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardIinput = Input.GetAxis("Vertical");
        // we move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardIinput );
        //we turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
        
    }
}
