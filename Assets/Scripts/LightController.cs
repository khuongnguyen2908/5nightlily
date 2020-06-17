using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LightController : MonoBehaviour
{

    public GameObject DoorLeft;
    public GameObject DoorRight;

    void Start()
    {
        DoorLeft.SetActive(true);
        DoorRight.SetActive(true);
    }

    void Update()
    {
        //All we're doing is toggling the doors. If they're active, we deactivate them; if they're inactive, we activate them

        if (Input.GetKeyDown(KeyCode.A))
        {
            DoorLeft.SetActive(!DoorLeft.activeSelf);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            DoorRight.SetActive(!DoorRight.activeSelf);
        }
        //If either of the doors are active,  Movement.IsOnStageOfDeath is true, otherwise it's false.
        /* Movement.IsOnStageOfDeath = (DoorLeft.activeSelf || DoorRight.activeSelf);*/
    }
}