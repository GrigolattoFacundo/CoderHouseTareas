using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    private int currentCamera;
    public GameObject thirdPersonCam;
    public GameObject commanderCam;
    public GameObject gunnerCam;

    private void Start()
    {
        currentCamera = 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown("v"))
        {
            if (currentCamera == 1)
            {
                thirdPersonCam.SetActive(false);
                commanderCam.SetActive(true);
                gunnerCam.SetActive(false);
                currentCamera++;
            }
            else if (currentCamera == 2)
            { 
                thirdPersonCam.SetActive(false);
                commanderCam.SetActive(false);
                gunnerCam.SetActive(true);
                currentCamera++;
            }
            else if (currentCamera == 3)
            {
                thirdPersonCam.SetActive(true);
                commanderCam.SetActive(false);
                gunnerCam.SetActive(false);
                currentCamera = 1;
            }
        }
    }
}
