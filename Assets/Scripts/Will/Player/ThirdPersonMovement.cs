using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    //Players current direction
    private Vector3 _direction;
    //Turning velocity
    private float _turnSmoothVelocity;

    //Lets users to refrence players direction
    public Vector3 Direction {  get => _direction; }

    //refence to the player controller
    public CharacterController controller;
    //refrence to the scenes camera 
    public Transform Camera;

    //Players current speed
    public float Speed = 6f;
    //Players turns smoothing speed
    public float TurnSmoothingTime = 0.1f;



    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        _direction.x = Input.GetAxisRaw("Horizontal");
        _direction.z = Input.GetAxisRaw("Vertical");

        _direction.Normalize();

        if (_direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(_direction.x, _direction.z) * Mathf.Rad2Deg + Camera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref _turnSmoothVelocity, TurnSmoothingTime);
            transform.rotation = Quaternion.Euler(0.0f, angle, 0.0f);


            Vector3 moveDir = Quaternion.Euler(0.0f, targetAngle, 0.0f) * Vector3.forward;
            controller.Move(moveDir.normalized * Speed * Time.fixedDeltaTime);
        }
    }
}