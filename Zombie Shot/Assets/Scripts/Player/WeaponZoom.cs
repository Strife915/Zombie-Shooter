using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;

    [SerializeField] float zoomedOutFOV = 50f;
    [SerializeField] float zoomedInFOV = 35f;

    

    [SerializeField] float zoomedOutSensivity = 2f;
    [SerializeField] float zoomedInSensivity = .5f;

    bool zoomedInToggle = false;

    
    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoomedInToggle == false)
            {
                zoomedInToggle = true;
                fpsCamera.fieldOfView = zoomedInFOV;
                fpsController.mouseLook.XSensitivity = zoomedInSensivity;
                fpsController.mouseLook.YSensitivity = zoomedInSensivity;
            }
            else
            {
                zoomedInToggle = false;
                fpsCamera.fieldOfView = zoomedOutFOV;
                fpsController.mouseLook.XSensitivity = zoomedOutSensivity;
                fpsController.mouseLook.YSensitivity = zoomedOutSensivity;
            }
        }
    }
}
