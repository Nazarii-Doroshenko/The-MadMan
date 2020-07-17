using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class CameraRotation : MonoBehaviour
{
    public CharacterController cameraController;
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Update()
    {
       if (Input.GetMouseButton(1))
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }

    }
   
    /*public CharacterController playerController;
    public Camera camera;

    void Update()
    {
        float speed = 3.0f;
        float xRot = speed * Input.GetAxis("Vertical");
        float yRot = speed * Input.GetAxis("Horizontal");

        playerController.Move(transform.Rotate(xRot, yRot, 0.0f));
    }*/

}
