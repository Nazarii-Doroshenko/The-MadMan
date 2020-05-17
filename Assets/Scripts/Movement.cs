using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float force;
    

    public Button forward;
    public Button left;
    public Button back; 
    public Button right;

    public new Rigidbody rigidbody;
    
    //Buttons;
    public void GoForward()
    {    
        rigidbody.AddForce(Vector3.forward * force);        
    }
    public void GoLeft()
    {             
        rigidbody.AddForce(Vector3.left * force);
    }    
    public void GoBack()
    {              
        rigidbody.AddForce(Vector3.back * force);
    }
    public void GoRight()
    {             
        rigidbody.AddForce(Vector3.right * force);
    }

    public void Inp()
    {       
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) /*|| Input.GetButtonDown("forward")*/) //Forward
        {
            GoForward();          
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) /*||  Input.GetButtonDown("left")*/) //Left
        {
            GoLeft();
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) /*|| Input.GetButtonDown("back")*/) //Back
        {
            GoBack();
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) /*|| Input.GetButtonDown("right")*/) // Right
        {
            GoRight();
        }
       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * force * 50);
        }*/
        
    }
    public void AppllyModifers()
    {
        
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            force *= 2 ;
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            force /= 10;
        }

    }
    
    void Update()
    {
        AppllyModifers();
        Inp();
    }
}
