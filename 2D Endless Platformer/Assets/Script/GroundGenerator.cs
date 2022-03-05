using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GroundGenerator : MonoBehaviour
{
    public TilemapCollider2D collider;
    public Rigidbody2D rb;
    private float width;

    private float scrollSpeed = -10f;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<TilemapCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = collider.bounds.extents.x;
        
        rb.velocity = new Vector2(scrollSpeed , 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -width) {
            Vector2 resetPosition = new Vector2(width * 2f , 0);
            transform.position = (Vector2) transform.position + resetPosition;
        }
        
    }
}
