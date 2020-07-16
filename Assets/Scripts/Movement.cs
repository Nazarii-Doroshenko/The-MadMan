using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float force = 10;
    public float jumpForce = 1000;

    public float maxForce = 40;
    public float minForce = 5;

    public bool canJump;

    /*Vector3 dx;
    Vector3 dy;
    Vector3 dz;
    */
    
   /* public Button forward;
    public Button left;
    public Button back; 
    public Button right;
    */
   new private Rigidbody rigidbody;

    //public LayerMask groundLayers;

    public SphereCollider col;

    //public GameObject player;

    public new GameObject camera;
    private bool IsGrounded = true;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.freezeRotation = true;
        col = GetComponent<SphereCollider>();
    }
    void Update()
    {  
        AppllyModifers();
        Inp();  
    }
    public void Jump()
    {
        rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        IsGrounded = true;
    }/*
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
    */
   


    public void Inp()
    {
        float horizontalInput = Input.GetAxis("Horizontal");


        float verticalInput = Input.GetAxis("Vertical");


        transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * force * Time.deltaTime);


        /*
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))//Forward
        {
            k = 1;
            Check();
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) //Left
        {
            k = 2;
            Check();
        }
    
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) //Back
        {
            k = 3;
            Check();
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) // Right
        {
            k = 4;
            Check();
        }
        */
        if ( canJump == true && Input.GetKeyDown(KeyCode.Space) && IsGrounded == true)
        {      
            Jump();
            IsGrounded = false;
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
    
   
    private void Check()
    {
        /*float fYRot = Camera.main.transform.eulerAngles.y;
        if (k == 1)
        {
            if (fYRot > -90 && fYRot < 90)
            {
                GoForward();
            }
            if (fYRot > 0 && fYRot < 180)
            {
                GoRight();
            }
            if (fYRot < 360 && fYRot > 180)
            {
                GoLeft();
            }
            if (fYRot < 270 && fYRot > 90)
            {
                GoBack();
            }
        }
        if( k == 2)
        {
            if (fYRot > -90 && fYRot < 90)
            {
                GoLeft();
            }
            if (fYRot > 0 && fYRot < 180)
            {
                GoForward();
            }
            if (fYRot < 360 && fYRot > 180)
            {
                GoBack();
            }
            if (fYRot < 270 && fYRot > 90)
            {
                GoRight();
            }
        }
        if(k == 3)
        {
            if (fYRot > -90 && fYRot < 90)
            {
                GoBack();
            }
            if (fYRot > 0 && fYRot < 180)
            {
                GoLeft();
            }
            if (fYRot < 360 && fYRot > 180)
            {
                GoRight();
            }
            if (fYRot < 270 && fYRot > 90)
            {
                GoForward();
            }
        }
        if( k == 4 )
        {
            if (fYRot > -90 && fYRot < 90)
            {
                GoRight();
            }
            if (fYRot > 0 && fYRot < 180)
            {
                GoBack();
            }
            if (fYRot < 360 && fYRot > 180)
            {
                GoForward();
            }
            if (fYRot < 270 && fYRot > 90)
            {
                GoLeft();
            }
        }
        */
    }
}
