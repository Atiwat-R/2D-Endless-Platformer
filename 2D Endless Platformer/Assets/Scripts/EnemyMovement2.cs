using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This one stays in place but jumps

public class EnemyMovement2 : MonoBehaviour
{
    [SerializeField] float jumpHeight = 30f;
    Rigidbody2D rgbd2D;

    BoxCollider2D myBoxCollider;
    
    // Start is called before the first frame update
    void Start()
    {
        rgbd2D = GetComponent<Rigidbody2D>();
        myBoxCollider = GetComponent<BoxCollider2D>();
        rgbd2D.freezeRotation = true; // Keep Enemy upright by preventing any rotation at all.
    }

    // Update is called once per frame
    void Update()
    {
        rgbd2D.velocity = new Vector2(0f, rgbd2D.velocity.y); // Always set its x-axis movement to zero, so that it is unaffected by surface effector.

        // Enemy movement. Jumps in place when it touch the ground
        if (!myBoxCollider.IsTouchingLayers(LayerMask.GetMask("Ground")) && !myBoxCollider.IsTouchingLayers(LayerMask.GetMask("Platform"))) return;
        rgbd2D.velocity = new Vector2(0f, jumpHeight); 
    }
}
