using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float jumpSpeed = 7.0f;
    [SerializeField] float dashSpeed = 10.0f;

    CapsuleCollider2D myCapsuleCollider;
    Rigidbody2D rigidbody2D;

    Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        myCapsuleCollider = GetComponent<CapsuleCollider2D>();
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Airborne();
    }

    // If player is airborne play animation
    void Airborne() {
        bool playerIsAirborne = rigidbody2D.velocity.y > Mathf.Epsilon;
        
        myAnimator.SetBool("isAirborne", playerIsAirborne);
    }

    // Jump using Keyboard Spacebar
    void OnJump(InputValue value)
    {
        if (!myCapsuleCollider.IsTouchingLayers(LayerMask.GetMask("Ground")) && !myCapsuleCollider.IsTouchingLayers(LayerMask.GetMask("Platform"))) return;
        if (value.isPressed) {
             rigidbody2D.velocity += new Vector2(0f, jumpSpeed * 2.0f); // Jump height boost
             myAnimator.SetTrigger("isJumping");
        }
    }
    // Dash using Keyboard D
    void OnDash(InputValue value)
    {
        if (value.isPressed) rigidbody2D.velocity += new Vector2(dashSpeed, 0f); // Speed Boost
    }
    // Brake using Keyboard A
    void OnBrake(InputValue value)
    {
        if (value.isPressed) rigidbody2D.velocity -= new Vector2(rigidbody2D.velocity.x/2, 0f); // Slow down by half of current velocity
    }

    // OnTriggerEnter2D is build-in to detect collisions and specify what happens.
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Enemies" || other.tag == "Hazards" ) {
            TakeDamage();
        }
    }

    // Implements GAME OVER
    void TakeDamage() {
        Debug.Log("Ouch");
        SceneManager.LoadScene("GameOver"); // Sends Player to Game Over scene
    }

}



// Code Storage

    // void DamageCheck(Collider2D other) {
    //     if (myCapsuleCollider.IsTouchingLayers(LayerMask.GetMask("Enemies")) || myCapsuleCollider.IsTouchingLayers(LayerMask.GetMask("Hazards"))) {
    //         Debug.Log("Ouch!");
    //     }
    // }
