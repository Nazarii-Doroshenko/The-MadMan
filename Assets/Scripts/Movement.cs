using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float force;
    MeshRenderer meshRenderer;

    public Button forward;
    public Button left;
    public Button back;
    public Button right;

    void Start()
    {
        meshRenderer = gameObject.GetComponent<MeshRenderer>();
    }
    //Buttons;
    public void GoForward()
    {
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        if (rigidbody == null)
            rigidbody = gameObject.AddComponent<Rigidbody>();

        
        rigidbody.AddForce(Vector3.forward * force);
        
    }
    public void GoLeft()
    {
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        if (rigidbody == null)
            rigidbody = gameObject.AddComponent<Rigidbody>();
        
        rigidbody.AddForce(Vector3.left * force);
        

    }    
    public void GoBack()
    {
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        if (rigidbody == null)
            rigidbody = gameObject.AddComponent<Rigidbody>();
        rigidbody.AddForce(Vector3.back * force);
    }
    public void GoRight()
    {
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        if (rigidbody == null)
            rigidbody = gameObject.AddComponent<Rigidbody>();
        rigidbody.AddForce(Vector3.right * force);
    }

    public void Inp()
    {
        
       
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
            GetComponent<Rigidbody>().AddForce(Vector3.right * force);
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
