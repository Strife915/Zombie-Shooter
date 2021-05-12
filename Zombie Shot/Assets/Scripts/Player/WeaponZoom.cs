using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedOutFOV = 50f;
    [SerializeField] float zoomedInFOV = 35f;

    RigidbodyFirstPersonController fpsController;

    //[SerializeField] float zoomedOutSensivity = 2f;
    //[SerializeField] float zoomedInSensivity = .5f;

    bool zoomedInToggle = false;

    private void Start()
    {
        fpsController = GetComponent<RigidbodyFirstPersonController>();

    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoomedInToggle == false)
            {
                zoomedInToggle = true;
                fpsCamera.fieldOfView = zoomedInFOV;
                fpsController.mouseLook.XSensitivity = .5f;
                fpsController.mouseLook.YSensitivity = .5f;
            }
            else
            {
                zoomedInToggle = false;
                fpsCamera.fieldOfView = zoomedOutFOV;
                fpsController.mouseLook.XSensitivity = 2f;
                fpsController.mouseLook.YSensitivity = 2f;
            }
        }
    }
}
