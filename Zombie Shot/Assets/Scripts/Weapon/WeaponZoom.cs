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

    public bool zoomedInToggle = false;

    private void OnDisable()
    {
        ZoomOut();
    }


    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoomedInToggle == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }

    private void ZoomOut()
    {
        zoomedInToggle = false;
        fpsCamera.fieldOfView = zoomedOutFOV;
        fpsController.mouseLook.XSensitivity = zoomedOutSensivity;
        fpsController.mouseLook.YSensitivity = zoomedOutSensivity;
    }

    private void ZoomIn()
    {
        zoomedInToggle = true;
        fpsCamera.fieldOfView = zoomedInFOV;
        fpsController.mouseLook.XSensitivity = zoomedInSensivity;
        fpsController.mouseLook.YSensitivity = zoomedInSensivity;
    }
}
