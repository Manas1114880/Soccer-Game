using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    private int team1Score = 0;
    private int team2Score = 0;
    public Text scoreText1;
    public Text scoreText2;

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Goal1"){
            team1Score++;
            print("I made it");
        }
        else if(other.gameObject.tag == "Goal2"){
            team2Score++;
            print("The opponint team made it");
        }
    }

    void Update()
    {
        scoreText1.text = "Team 1 Score: " + team1Score;
        scoreText2.text = "Team 2 Score: " + team2Score;
    }
}
