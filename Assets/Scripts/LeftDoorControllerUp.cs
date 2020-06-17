using UnityEngine;
using System.Collections;

public class LeftDoorControllerUp : Power
{

    public GameObject Door;
    public bool doorIsOpening;

    void start()
    {
        wattage = 10.0f;
    }
    void Update()
    {
        if (doorIsOpening == true)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 5);
            PowerManager.Instance.UsePower(this);
            //if the bool is true open the door
        }
        if (Door.transform.position.y >= 13f)
        {
            doorIsOpening = false;

        }

    }
    void OnMouseDown()
    { //This function will detect the mouse click on a collider

        doorIsOpening = true;
        PowerManager.Instance.UsePower(this);
        //if we click on the button door must start to open
    }

    public override void OnPowerOutage()
    {
        if( doorIsOpening == false)
        {
            StartCoroutine("openDoor");
        }

        this.enabled = false;
    }
}