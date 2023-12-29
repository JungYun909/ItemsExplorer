using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{

    private TopDownCharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovment(_movementDirection);
    }


    private void Move(Vector2 direction)
    {
        _movementDirection = direction;


        if (Input.GetKeyDown("a") || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localScale = new Vector3(1, 1, 1);
            Debug.Log("¿ÞÂÊ");

        }
        else if (Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localScale = new Vector3(-1, 1, 1);
            Debug.Log("¿À¸¥ÂÊ");

        }

    }

    private void ApplyMovment(Vector2 direction)
    {
        direction = direction * 5;

        _rigidbody.velocity = direction;
    }
}