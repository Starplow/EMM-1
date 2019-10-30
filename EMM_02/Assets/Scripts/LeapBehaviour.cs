﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;



public class LeapBehaviour : MonoBehaviour
{
    LeapServiceProvider provider;


    public float movementSpeed = 5f;
    public float rotateSpeed = 1f;

    //Rotate Angle
    public float rotateAngle;
    public Quaternion targetRotation;
    public Rigidbody rb;
    public float thrust;
    
    // Start is called before the first frame update
    void Start() { 
        provider = FindObjectOfType<LeapServiceProvider>() as LeapServiceProvider;

        rb = GetComponent<Rigidbody>();
    }
   
    // Update is called once per frame
    void Update()
    {
        Frame frame = provider.CurrentFrame;
        foreach (Hand hand in frame.Hands){

            float yaw = hand.Direction.Yaw;
            Debug.Log("Neigung" +yaw);

            // transform.position = hand.PalmPosition.ToVector3() + hand.PalmNormal.ToVector3() * (transform.localScale.y * .5f + .02f);
            // transform.rotation = hand.Basis.rotation.ToQuaternion();

            if(yaw > -Mathf.PI && yaw < 0)
            {
                transform.position += transform.forward * Time.deltaTime  * 5;
            }
            else if (yaw < Mathf.PI && yaw > 0)
            {
                transform.position += (transform.forward * -1) * Time.deltaTime * 5;
            }

            //Rotation
            
            LeapQuaternion rotate = hand.Rotation;
            Debug.Log("Rotate: " + rotate);

            rotateAngle += rotate.y * rotateSpeed;
            Vector3 targetDirection = new Vector3(Mathf.Sin(rotateAngle), 0, Mathf.Cos(rotateAngle));
            targetRotation = Quaternion.LookRotation(targetDirection);
            transform.rotation = targetRotation;

           
            //Jump
            Vector palm = hand.PalmVelocity;

            if (palm.y >= 0.5)
                rb.AddForce(transform.up * thrust);
            Debug.Log("PalmVelocity: " + palm);





        }
        
    }
}
