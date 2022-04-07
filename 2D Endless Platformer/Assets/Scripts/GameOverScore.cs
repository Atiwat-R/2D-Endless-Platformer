using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{

    public Text FinalScore;


    void Start()
    {
        float toDisplay = PlayerPrefs.GetFloat("FinalScore");
        FinalScore.text = "SCORE:" + Mathf.Round(toDisplay);
        Debug.Log(toDisplay);
    }


}
