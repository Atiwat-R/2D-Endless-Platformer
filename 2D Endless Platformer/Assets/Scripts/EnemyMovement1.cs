using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This one runs left adsentmindedly.

public class EnemyMovement1 : MonoBehaviour
{
    [SerializeField] float moveSpeed = -5f;
    Rigidbody2D rgbd2D;
    
    // Start is called before the first frame update
    void Start()
    {
        rgbd2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rgbd2D.velocity = new Vector2(moveSpeed, rgbd2D.velocity.y); // Enemy movement. Its x-axis movement is constant to bypass surface effector, while its y-axis is affected by gravity. 
    }
}
