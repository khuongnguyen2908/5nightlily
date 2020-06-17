using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightDoorControllerUp : MonoBehaviour
{
    public GameObject Door;
    public bool doorIsOpening;

    void Update()
    {
        if (doorIsOpening == true)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 5);
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
        //if we click on the button door must start to open
    }

}
