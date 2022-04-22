using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheels : MonoBehaviour
{
    private WheelJoint2D wJ2D;
    private JointMotor2D motor;
    public RollingPlatform rP;
    public Topes right;
    public Topes left;
    public float speed;

    void Start()
    {        
        wJ2D = GetComponent<WheelJoint2D>();
        motor = wJ2D.motor;
    }

    // Update is called once per frame
    void Update()
    {   
       if(rP.isPlayer && !right.isWall) 
       {
           motor.motorSpeed = speed;    
       }
       if(rP.isPlayer && right.isWall) 
       {
           motor.motorSpeed = 0;    
       }
       if(!rP.isPlayer && (right.isWall ||  left.isWall))
       {
           motor.motorSpeed = 0;
       }
       if(!rP.isPlayer && !right.isWall &&  !left.isWall)
       {
           motor.motorSpeed = -speed;
       }
       wJ2D.motor = motor;
    }

    /*IEnumerator Timer()
    {
        yield return new WaitForSeconds(2f);
        speed = -speed;
    }*/

}

