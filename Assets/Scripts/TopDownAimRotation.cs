using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TopDownAimRotation : MonoBehaviour
{

    TopDownCharacterController _controller;
    [SerializeField] private SpriteRenderer charaterRenderer;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }


    void OnAim(Vector2 aimDirection)
    {
        Rotate(aimDirection);
    }

    void Rotate(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        charaterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
