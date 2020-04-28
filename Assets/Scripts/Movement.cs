using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float force;
    MeshRenderer meshRenderer;
    void Start()
    {
        meshRenderer = gameObject.GetComponent<MeshRenderer>();
    }
    public void Inp()
    {
        
        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
        if (rigidbody == null)
            rigidbody = gameObject.AddComponent<Rigidbody>();
        
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(Vector3.forward * force);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(Vector3.left * force);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(Vector3.back * force);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(Vector3.right * force);
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
