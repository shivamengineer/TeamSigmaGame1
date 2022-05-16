using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowsPlayer : MonoBehaviour {
    
    public GameObject Player;
    private Vector3 shiftPosition = new Vector3(0, 0, -10);
    public bool lockedCamera;
    private bool rightCam = false;
    private bool leftCam = false;
    private bool upCam = false;
    private bool downCam = false;
    public Vector3 camMovement;
    public Vector3 camSpeed = new Vector3(0.0f, 0.0f, 0.0f);
    private bool centered;


    // Start is called before the first frame update
    void Start(){
        lockedCamera = true;
    }

    // Update is called once per frame
    void LateUpdate(){
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            if(lockedCamera){
                lockedCamera = false;
            } else {
                lockedCamera = true;
            }
        }
        if(lockedCamera){
        transform.position = Player.transform.position + shiftPosition;
        } else{
            if(Input.GetKeyDown(KeyCode.Alpha1)){
                centered = true;
            }
            if(Input.GetKeyUp(KeyCode.Alpha1)){
                centered = false;
            }
            if(Input.GetKeyDown(KeyCode.V)){
                leftCam = true;
            }
            if(Input.GetKeyUp(KeyCode.V)){
                leftCam = false;
            }
            if(Input.GetKeyDown(KeyCode.N)){
                rightCam = true;
            }
            if(Input.GetKeyUp(KeyCode.N)){
                rightCam = false;
            }
            if(Input.GetKeyDown(KeyCode.G)){
                upCam = true;
            }
            if(Input.GetKeyUp(KeyCode.G)){
                upCam = false;
            }
            if(Input.GetKeyDown(KeyCode.B)){
                downCam = true;
            }
            if(Input.GetKeyUp(KeyCode.B)){
                downCam = false;
            }
            if(centered){
                transform.position = Player.transform.position + shiftPosition;
            } else {

                if((rightCam&&leftCam)||((rightCam==false)&&(leftCam==false))){
                    camSpeed.x = 0.0f;
                } else {
                    if(leftCam){
                        camSpeed.x = (-0.2f);
                    }
                    if(rightCam){
                        camSpeed.x = (0.2f);
                    }
                }
                if(upCam&&downCam||((upCam==false)&&(downCam==false))){
                    camSpeed.y = 0.0f;
                } else {
                    if(upCam){
                        camSpeed.y = (0.2f);
                    }
                    if(downCam){
                        camSpeed.y = (-0.2f);
                    }
                }
                transform.position += camSpeed;
            }
        }
    }
}
