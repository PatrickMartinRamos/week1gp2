using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Lumin;

public class move : MonoBehaviour
{
    private Input_player playerInput = null;
    private Vector3 moveVector =Vector3.zero;
    private Rigidbody rb;
    public float speed;

    private void Awake()
    {
        playerInput = new Input_player();
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.velocity = moveVector * speed;
    }

    private void OnEnable()
    {
        playerInput.Enable();
        playerInput.Player.move.performed += onMovementpeformed;
        playerInput.Player.move.canceled += onMovementcancel;
    }

    private void OnDisable()
    {
        playerInput.Player.move.performed -= onMovementpeformed;
        playerInput.Player.move.canceled -= onMovementcancel;
    }
    private void onMovementpeformed(InputAction.CallbackContext value)
    {
        moveVector = value.ReadValue<Vector3>();
    }
    private void onMovementcancel(InputAction.CallbackContext value)
    {
        moveVector = Vector3.zero;
    }
}
