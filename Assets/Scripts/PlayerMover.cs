using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMover : MonoBehaviour
{

    [SerializeField] private float speed = 5f;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 move;

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        movePlayer();
    }

    public void movePlayer()
    {
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }
}
