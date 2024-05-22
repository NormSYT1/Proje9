using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController characterController;
    private float speed = 8f;

    Vector3 velocity;
    public Transform camera;
    private float lookSensitivity = 100f;
    private float maxXrotation = +80f;
    private float minXrotation = -80f;
    private float currentXrotation;
    void Start()
    {
        
    }
    void Update()
    {
        //Karakter hareket
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");
        Vector3 move = transform.right * xMove + transform.forward * zMove;
        characterController.Move(move * speed * Time.deltaTime);
        characterController.Move(velocity * Time.deltaTime);

        //Fare hareket
        float x = Input.GetAxis("Mouse X") * lookSensitivity * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * lookSensitivity * Time.deltaTime;

        transform.eulerAngles += Vector3.up * x;
        currentXrotation += y;
        currentXrotation = Mathf.Clamp(currentXrotation, minXrotation, maxXrotation);
        camera.localEulerAngles = new Vector3(-currentXrotation, 0f, 0f);
    }
}
