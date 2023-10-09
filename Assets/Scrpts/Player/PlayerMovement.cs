using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 5;
    private CharacterController _controller;
    private Vector3 movement = Vector3.zero;
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        movement = transform.right * x + transform.forward * y;
        movement.Normalize();
        // transform.forward = movement;
        _controller.Move(movement * speed * Time.deltaTime);
    }
}