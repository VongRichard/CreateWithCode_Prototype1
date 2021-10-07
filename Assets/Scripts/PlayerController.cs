using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 100.0f;
    private float horizontalInput;
    private float forwardInput = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        // Delta time is change in time every second.

        //Moves car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Moves car backward
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
    }
}
