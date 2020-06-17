using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera cameraSecurityRoom;
    public Camera camera1A;
    public Camera camera1B;
    public Camera camera1C;
    public Camera camera2A;
    public Camera camera2B;
    public Camera camera2C;
    public Camera camera3A;
    public Camera camera3B;
    public Camera camera3C;
    public Camera cameraK;
    public Camera cameraD;

    protected Camera[] cameras;

    [SerializeField]
    protected int CurrentCamera;

    void Awake()
    {
        cameras = new Camera[12];

        cameras[0] = cameraSecurityRoom;
        cameras[1] = camera1A;
        cameras[2] = camera1B;
        cameras[3] = camera1C;
        cameras[4] = camera2A;
        cameras[5] = camera2B;
        cameras[6] = camera2C;
        cameras[7] = camera3A;
        cameras[8] = camera3B;
        cameras[9] = camera3C;
        cameras[10] = cameraK;
        cameras[11] = cameraD;



    }
    void Start()
    {
       
    }

    void incCamera()
    {
        cameras[CurrentCamera].GetComponent<AudioListener>().enabled = false;
        cameras[CurrentCamera].enabled = false;
        CurrentCamera++;

        if (CurrentCamera >= cameras.Length)
        {
            CurrentCamera = 0;
        }
        cameras[CurrentCamera].GetComponent<AudioListener>().enabled = true;
        cameras[CurrentCamera].enabled = true;
    }

    void decCamera()
    {
        cameras[CurrentCamera].GetComponent<AudioListener>().enabled = false;
        cameras[CurrentCamera].enabled = false;
        CurrentCamera--;

        if (CurrentCamera < 0)
        {
            CurrentCamera = cameras.Length - 1;
        }
        cameras[CurrentCamera].GetComponent<AudioListener>().enabled = true;
        cameras[CurrentCamera].enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            incCamera();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            decCamera();
        }
    }

    
}
