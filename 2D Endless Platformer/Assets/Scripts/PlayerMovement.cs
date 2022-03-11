using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float jumpSpeed = 7.0f;
    CapsuleCollider2D myCapsuleCollider;
    Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        myCapsuleCollider = GetComponent<CapsuleCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnJump(InputValue value)
    {
        if (!myCapsuleCollider.IsTouchingLayers(LayerMask.GetMask("Ground")) && !myCapsuleCollider.IsTouchingLayers(LayerMask.GetMask("Platform"))) return;
        if (value.isPressed) rigidbody2D.velocity += new Vector2(0f, jumpSpeed * 2.0f); // Jump height boost
    }

    void DamageCheck() {
        if (myCapsuleCollider.IsTouchingLayers(LayerMask.GetMask("Enemies")) || myCapsuleCollider.IsTouchingLayers(LayerMask.GetMask("Hazards"))) {
            Debug.Log("Ouch!");
        }
    }
}
