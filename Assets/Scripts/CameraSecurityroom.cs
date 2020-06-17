using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSecurityroom : MonoBehaviour
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

    // Start is called before the first frame update
   public void CamSecurity()
    {
        cameraSecurityRoom.enabled = true;
        camera1A.enabled = false;
        camera1B.enabled = false;
        camera1C.enabled = false;
        camera2A.enabled = false;
        camera2B.enabled = false;
        camera2C.enabled = false;
        camera3A.enabled = false;
        camera3B.enabled = false;
        camera3C.enabled = false;
        cameraK.enabled = false;
        cameraD.enabled = false;

    }

    public void Camera1A()
    {
        cameraSecurityRoom.enabled = false;
        camera1A.enabled = true;
        camera1B.enabled = false;
        camera1C.enabled = false;
        camera2A.enabled = false;
        camera2B.enabled = false;
        camera2C.enabled = false;
        camera3A.enabled = false;
        camera3B.enabled = false;
        camera3C.enabled = false;
        cameraK.enabled = false;
        cameraD.enabled = false;
    }

    public void Camera1B()
    {
        cameraSecurityRoom.enabled = false;
        camera1A.enabled = false;
        camera1B.enabled = true;
        camera1C.enabled = false;
        camera2A.enabled = false;
        camera2B.enabled = false;
        camera2C.enabled = false;
        camera3A.enabled = false;
        camera3B.enabled = false;
        camera3C.enabled = false;
        cameraK.enabled = false;
        cameraD.enabled = false;
    }

    public void Camera1C()
    {
        cameraSecurityRoom.enabled = false;
        camera1A.enabled = false;
        camera1B.enabled = false;
        camera1C.enabled = true;
        camera2A.enabled = false;
        camera2B.enabled = false;
        camera2C.enabled = false;
        camera3A.enabled = false;
        camera3B.enabled = false;
        camera3C.enabled = false;
        cameraK.enabled = false;
        cameraD.enabled = false;
    }

    public void Camera2A()
    {
        cameraSecurityRoom.enabled = false;
        camera1A.enabled = false;
        camera1B.enabled = false;
        camera1C.enabled = false;
        camera2A.enabled = true;
        camera2B.enabled = false;
        camera2C.enabled = false;
        camera3A.enabled = false;
        camera3B.enabled = false;
        camera3C.enabled = false;
        cameraK.enabled = false;
        cameraD.enabled = false;
    }

    public void Camera2B()
    {
        cameraSecurityRoom.enabled = false;
        camera1A.enabled = false;
        camera1B.enabled = false;
        camera1C.enabled = false;
        camera2A.enabled = false;
        camera2B.enabled = true;
        camera2C.enabled = false;
        camera3A.enabled = false;
        camera3B.enabled = false;
        camera3C.enabled = false;
        cameraK.enabled = false;
        cameraD.enabled = false;
    }

    public void Camera2C()
    {
        cameraSecurityRoom.enabled = false;
        camera1A.enabled = false;
        camera1B.enabled = false;
        camera1C.enabled = false;
        camera2A.enabled = false;
        camera2B.enabled = false;
        camera2C.enabled = true;
        camera3A.enabled = false;
        camera3B.enabled = false;
        camera3C.enabled = false;
        cameraK.enabled = false;
        cameraD.enabled = false;
    }

    public void Camera3A()
    {
        cameraSecurityRoom.enabled = false;
        camera1A.enabled = false;
        camera1B.enabled = false;
        camera1C.enabled = false;
        camera2A.enabled = false;
        camera2B.enabled = false;
        camera2C.enabled = false;
        camera3A.enabled = true;
        camera3B.enabled = false;
        camera3C.enabled = false;
        cameraK.enabled = false;
        cameraD.enabled = false;
    }

    public void Camera3B()
    {
        cameraSecurityRoom.enabled = false;
        camera1A.enabled = false;
        camera1B.enabled = false;
        camera1C.enabled = false;
        camera2A.enabled = false;
        camera2B.enabled = false;
        camera2C.enabled = false;
        camera3A.enabled = false;
        camera3B.enabled = true;
        camera3C.enabled = false;
        cameraK.enabled = false;
        cameraD.enabled = false;
    }

    public void Camera3C()
    {
        cameraSecurityRoom.enabled = false;
        camera1A.enabled = false;
        camera1B.enabled = false;
        camera1C.enabled = false;
        camera2A.enabled = false;
        camera2B.enabled = false;
        camera2C.enabled = false;
        camera3A.enabled = false;
        camera3B.enabled = false;
        camera3C.enabled = true;
        cameraK.enabled = false;
        cameraD.enabled = false;
    }

    public void CameraK()
    {
        cameraSecurityRoom.enabled = false;
        camera1A.enabled = false;
        camera1B.enabled = false;
        camera1C.enabled = false;
        camera2A.enabled = false;
        camera2B.enabled = false;
        camera2C.enabled = false;
        camera3A.enabled = false;
        camera3B.enabled = false;
        camera3C.enabled = false;
        cameraK.enabled = true;
        cameraD.enabled = false;
    }

    public void CameraD()
    {
        cameraSecurityRoom.enabled = false;
        camera1A.enabled = false;
        camera1B.enabled = false;
        camera1C.enabled = false;
        camera2A.enabled = false;
        camera2B.enabled = false;
        camera2C.enabled = false;
        camera3A.enabled = false;
        camera3B.enabled = false;
        camera3C.enabled = false;
        cameraK.enabled = false;
        cameraD.enabled = true;
    }
}
