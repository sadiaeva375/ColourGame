using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    // variables
    private Vector2 movement;
    private Rigidbody2D rigidBody;
    [SerializeField] private float speed; 

    private void Awake()
    {
        rigidBody = GameObject.Find("Player").GetComponent<Rigidbody2D>();
    }
    private void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + movement * speed * Time.fixedDeltaTime);
    }
}
