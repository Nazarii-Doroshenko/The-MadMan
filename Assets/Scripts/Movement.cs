using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public CharacterController playerController;
    public float xForce = 1.0f;
    public float force = 40;
    public float jumpForce = 50;

    public bool canJump;
    private Vector3 moveDirection = Vector3.zero;
    public float gravity = 20.0F;

    new private Rigidbody rigidbody;

    public SphereCollider col;

    public new GameObject camera;
    bool IsGrounded = true;


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
            IsGrounded = false;
            moveDirection.y = jumpForce;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        playerController.Move(moveDirection * Time.deltaTime);
    }

    public void JumpInp()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded == true && canJump == true)
        {
            IsGrounded = false;
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
        xForce = PlayerPrefs.GetFloat("xForce");
        if (xForce <= 0) { xForce = 1; PlayerPrefs.SetFloat("xForce", xForce); }
        Vector3 mov = new Vector3(SimpleInput.GetAxis("Horizontal") * (force * xForce), 0, SimpleInput.GetAxis("Vertical") * (force * xForce));
        playerController.Move(mov * Time.deltaTime);
        JumpInp();
    }
    public void Xforce()
    {    
        int c;
        c = PlayerPrefs.GetInt("money");
        if (c > 0)
        {
            xForce++;
            PlayerPrefs.SetFloat("xForce", xForce);
            c--;
            PlayerPrefs.SetInt("money", c);
            PlayerPrefs.Save();
        }
    }
}
   
   
