using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI score;
    public int scoreValue;
    void updateScore()
    {
        score.text = ("Score: " + scoreValue);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 3)
        {
            scoreValue++;
            updateScore();
        } 
    }
}
