using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float force;
    public float jumpForce = 1000;

    public float maxForce = 40;
    public float minForce = 5;

    public bool canJump;

    /*int dx;
    int dy;
    int dz;
    */
   /* public Button forward;
    public Button left;
    public Button back; 
    public Button right;
    */
    public new Rigidbody rigidbody;
    
    public void GoForward()
    {
        
        transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * force;
        
    }

    public void GoLeft()
    {
        transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * force;

    }  
    
    public void GoBack()
    {
        transform.position += transform.TransformDirection(Vector3.back) * Time.deltaTime * force;

    }

    public void GoRight()
    {
        transform.position += transform.TransformDirection(Vector3.right) * Time.deltaTime * force;

    }

    public void Jump()
    {
       rigidbody.AddForce(Vector3.up * jumpForce);
       //transform.position += transform.TransformDirection(Vector3.up) * Time.deltaTime * jumpForce;
    }


    public void Inp()
    {
        rigidbody.freezeRotation = true;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) //Forward
        {
            GoForward();          
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) //Left
        {
            GoLeft();
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) //Back
        {
            GoBack();
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) // Right
        {
            GoRight();
        }
        if( canJump == true && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

    }

    public void AppllyModifers()
    {       
        if (Input.GetKey(KeyCode.LeftShift) && force < maxForce)
        { 
            force *= 2;
        }
        if (Input.GetKey(KeyCode.LeftControl) && force > minForce)
        {
            force /= 2;
        }           
    }
    
    void Update()
    {
        
        AppllyModifers();
        Inp();
    }
}
