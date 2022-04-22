using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipToHazardPlatform : MonoBehaviour
{
    private HingeJoint2D hJ2D;
    private JointMotor2D motor;
    public bool isHazard;

    void Start()
    {        
        hJ2D = GetComponent<HingeJoint2D>();
        motor = hJ2D.motor;
        isHazard = false;
    }

    // Update is called once per frame
    void Update()
    {   
       if(!isHazard) 
       {
           motor.motorSpeed = 50;    
           if(hJ2D.jointAngle >= 180)
           {    
               motor.motorSpeed = 0;
               StartCoroutine(Timer());
           }
       }
       if(isHazard)
       {
           motor.motorSpeed = -50;
           if(hJ2D.jointAngle <= 1)
           {
               motor.motorSpeed = 0;
               StartCoroutine(Timer2());
           }
       }
       Debug.Log(hJ2D.jointAngle);
       hJ2D.motor = motor;
    }

     IEnumerator Timer()
    {
        yield return new WaitForSeconds(2f);
        isHazard = true;
    }

     IEnumerator Timer2()
    {
        yield return new WaitForSeconds(2f);
        isHazard = false;
    }


}
