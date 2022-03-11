using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.7f;
    Rigidbody2D rgbd2D;
    
    // Start is called before the first frame update
    void Start()
    {
        rgbd2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rgbd2D.velocity = new Vector2(moveSpeed, 0f);
    }
}
