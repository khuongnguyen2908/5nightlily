using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDoorControllerDown : Power
{
    public GameObject Door;
    public bool doorIsClosing;

    void Update()
    {
        if (doorIsClosing == true)
        {
            Door.transform.Translate(Vector3.down * Time.deltaTime * 5);
            PowerManager.Instance.ReleasePower(this);
            //if the bool is true open the door
        }
        if (Door.transform.position.y < 6f)
        {
            doorIsClosing = false;

        }
    }
    void OnMouseDown()
    { //This function will detect the mouse click on a collider

        doorIsClosing = true;
        //if we click on the button door must start to open
    }

    public override void OnPowerOutage()
    {

    }
}