
using UnityEngine;
using System.Collections;
//This file is responsible for the players motion
public class PlayerMotion : MonoBehaviour
{

    public float speed;

    // TODO; Need to figure what the start method does
//I will replace this comment above with a more meaningfull response once I get waht is acctually does
//gyedgyedgqwkgwkjhegdjkghwejk this is nothing stuff... why no change?
    public Start(){
      
    }


    public Vector3 Update(){

        float speed = 5.0;
        float xDirection = speed*Input.GetAxis("Horizontal");
        float zDirection = speed*Input.GetAxis("Vertical");

       Vector3 motion = transform.Translate(xDirection, 0,zDirection);

       return motion;
    }
}
