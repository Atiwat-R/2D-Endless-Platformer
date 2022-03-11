using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    [SerializeField]
     private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 toTarget = player.transform.position - transform.position;
        float speed = 0.3f;

        transform.Translate(toTarget * speed * Time.deltaTime);
        
    }

    void OnCollisionEnter2D (Collision2D col)
     {
         Destroy(col.collider.gameObject);
       
     }
}
