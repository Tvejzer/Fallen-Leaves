using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float speed = 5f;
    private Rigidbody2D rb;
    private bool movementAllowed;
    private Vector2 move;

    private void Awake()
    {
        movementAllowed = true;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;
        }
        HandleMovement();
    }

    public void HandleMovement()
    {
        Vector2 move = InputManager.GetInstance().GetMoveDirection();
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }


    public bool MovementAllowed
    {
        get
        {
            return movementAllowed;
        }
        set
        {
            movementAllowed = value;
        }
    }
}
