using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 15.5f;
    public float turnSpeed;
    public float horizontalInput;

    public float veriticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


         // This allows you to use the keyboard to move left and right
       
        // Move the vehicle forward
      

        //transform.Translate(0, 0, 1);
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // Move the car left or right
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);

        horizontalInput = Input.GetAxis("Horizontal");
        veriticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * veriticalInput);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        
        
        
       

    }
}
