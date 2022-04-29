
using UnityEngine;
using System.Collections;
//This file is responsible for the players motion
public class PlayerMotion : MonoBehaviour
{

    public float speed;

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
