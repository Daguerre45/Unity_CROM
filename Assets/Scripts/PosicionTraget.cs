using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PosicionTraget : MonoBehaviour
{
//    //distance between the camera and the arrows
//    private int DISTANCE = 1;

//    public Transform cam;

//    void Update()
//    {
//        //first we get the camera position and rotation
//        Transform cameraTransform = cam.GetComponent<Transform>();
//        Quaternion rotCam = cameraTransform.rotation;
//        Vector3 posCam = cameraTransform.position;

//        //This two lines make the arrows face the camera no matter where it is.
//        Vector3 relativePos = posCam - transform.position;
//        transform.rotation = Quaternion.LookRotation(-relativePos);

//        //next line places the arrows always in front of the camera
//        transform.position = posCam + (rotCam * Vector3.forward) * DISTANCE;
//    }

}