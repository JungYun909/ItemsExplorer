using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{

    public GameObject frontsprite;
    public GameObject backsprite;
    public GameObject sidesprite;

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

            sidesprite.SetActive(true);
            backsprite.SetActive(false);
            frontsprite.SetActive(false);

            sidesprite.transform.localScale = new Vector3(1, 1, 1);
            Debug.Log("왼쪽");

        }
        else if (Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.RightArrow))
        {
            sidesprite.SetActive(true);
            backsprite.SetActive(false);
            frontsprite.SetActive(false);
            sidesprite.transform.localScale = new Vector3(-1, 1, 1);
            Debug.Log("오른쪽");

        }

        else if (Input.GetKeyDown("s") || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            frontsprite.SetActive(true);
            sidesprite.SetActive(false);
            backsprite.SetActive(false);
            Debug.Log("아래");

        }

        else if (Input.GetKeyDown("w") || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            frontsprite.SetActive(false);
            sidesprite.SetActive(false);
            backsprite.SetActive(true);
            Debug.Log("위");

        }

    }

    private void ApplyMovment(Vector2 direction)
    {
        direction = direction * 5;

        _rigidbody.velocity = direction;
    }
}