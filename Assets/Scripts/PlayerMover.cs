using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMover : MonoBehaviour
{

    [SerializeField] private float speed = 5f;
    private Rigidbody2D rb;
    private PlayerInteractor MovementManager;
    private Vector2 move;
    private bool interactPressed = false;



    public bool InteractPressed
    {
        get
        {
            return interactPressed;
        }
        set 
        {
            interactPressed = value;
        }
    }
    
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        MovementManager = FindObjectOfType<PlayerInteractor>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    public void OnInteraction(InputAction.CallbackContext context)
    {
        if (context.performed) 
        {
            print("Pressed");
            interactPressed = true;
        }
        else if (context.canceled) 
        {
            interactPressed = false;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (MovementManager.PlayerMovement)
        {
            movePlayer();
        }
    }

    public void movePlayer()
    {
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }
}
