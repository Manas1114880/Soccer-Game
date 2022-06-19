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
        }
        else if(other.gameObject.tag == "Goal2"){
            scoreResults.scoreIncrementation2();
        }
    }
}

