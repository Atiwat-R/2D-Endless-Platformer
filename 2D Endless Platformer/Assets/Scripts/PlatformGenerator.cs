using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public Transform generationPoint;
    public float distanceBetween;

    public float distanceBetweenMin;
    public float distanceBetweenMax;

    public GameObject[] platforms;
    private int platformSelector;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < generationPoint.position.x)
        {
            platformSelector = Random.Range(0, platforms.Length);

            GameObject currentPlatform = platforms[platformSelector];

            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            transform.position = new Vector3(transform.position.x + currentPlatform.GetComponent<BoxCollider2D>().size.x + distanceBetween, currentPlatform.transform.position.y, transform.position.z);

            Instantiate(currentPlatform, transform.position, transform.rotation);
        }
        
    }
}
