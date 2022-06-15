
using UnityEngine;
using System.Collections;
//This file is responsible for the players motion
public class PlayerMotion : MonoBehaviour
{

    public float speed;

    // This method is to execute your code on every single frame
    public void Start(){
      
    }

 //Executes code for every other frame
    public void Update(){
      double speed = 0.5;
      float xDirection = (float)speed*Input.GetAxis("Horizontal");
      float zDirection = (float)speed*Input.GetAxis("Vertical");
      this.transform.Translate(xDirection , 0.0f, zDirection);

    }
}
