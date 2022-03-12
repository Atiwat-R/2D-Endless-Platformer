using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;

    public float scoreCount; 

    public float pointsPerSecond;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreCount += pointsPerSecond * Time.deltaTime;
        
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
    }

    public void AddScore(int points) {
        scoreCount += points;
    }
}
