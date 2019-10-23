using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;        //Public variable to store a reference to the player game object
    public Transform playerObject;
    private Vector3 offsetVector;            //Private variable to store the offset distance between the player and camera
    public bool cameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        cameraPosition = true;
        offsetVector = transform.position - player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("SPACE");
            if(cameraPosition == true) { 
            cameraPosition = false;
            }
            else
            {
                cameraPosition = true;
            }
        }

    

        if (cameraPosition == true)
        {
            Vector3 offsetRotated = player.transform.rotation * offsetVector;
            transform.rotation = player.transform.rotation;
            transform.position = player.transform.position + offsetRotated;
           
        }
        else if (cameraPosition == false) {
            Vector3 changePosition = new Vector3(0.0f, 10.0f, 0.0f);
            transform.position = player.transform.position + changePosition;
            transform.rotation = Quaternion.Euler(90, 0, 0);
        }
    }
}
