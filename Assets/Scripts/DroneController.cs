using System;
using UnityEngine;

public class DroneController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10f;

    private void FixedUpdate()
    {
        ManageDroneMovement();
    }

    private void ManageDroneMovement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveX, moveY, 0f) * (_speed * Time.deltaTime);
        
        transform.Translate(movement);
    }
}
