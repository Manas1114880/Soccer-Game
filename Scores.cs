using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{

    public ScoreIncrement scoreResults = new ScoreIncrement();

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Goal1"){
            scoreResults.scoreIncrementation1();
            print("I made it");
        }
        else if(other.gameObject.tag == "Goal2"){
            scoreResults.scoreIncrementation2();
            print("The opponint team made it");
        }
    }
}

