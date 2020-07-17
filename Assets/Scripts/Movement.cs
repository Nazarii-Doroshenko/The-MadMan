using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public CharacterController playerController;
    public float force = 40;
    public float jumpForce = 50;

    public bool canJump;
    private Vector3 moveDirection = Vector3.zero;
    public float gravity = 20.0F;

    new private Rigidbody rigidbody;

    public SphereCollider col;

    public new GameObject camera;
    private bool IsGrounded = true;

    void Start()
    {
        playerController = GetComponent<CharacterController>();
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.freezeRotation = true;
        col = GetComponent<SphereCollider>();
    }
    void Update()
    {  
        Inp();  
    }
    public void JumpForUI()
    {
        if (IsGrounded == true && canJump == true)
        {
            moveDirection.y = jumpForce;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        playerController.Move(moveDirection * Time.deltaTime);
    }
    public void Jump()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded == true && canJump == true)
        {
            moveDirection.y = jumpForce;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        playerController.Move(moveDirection * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        IsGrounded = true;
    }
    
 // transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * force;
   


    public void Inp()
    {
        Vector3 mov = new Vector3(SimpleInput.GetAxis("Horizontal") * force, 0, SimpleInput.GetAxis("Vertical") * force);
        playerController.Move(mov * Time.deltaTime);
        Jump();
        


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
