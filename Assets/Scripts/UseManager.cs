using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseManager : MonoBehaviour
{
    public Camera SecurityRoom;
    public Collider LightControl_L_1;
    public Collider DoorControl_L_1;
    public Collider LightControl_R_1;
    public Collider DoorControl_R_1;

    public Light leftLight;
    public Light rightLight;

    public SecurityDoor doorLeft;
    public SecurityDoor doorRight;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = new Ray (SecurityRoom.transform.position,SecurityRoom.ScreenToWorldPoint(Input.mousePosition));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 10.0f))
            {
                if(hit.collider == LightControl_L_1)
                {
                    Debug.Log("LightControlLeft");
                }

                if (hit.collider == DoorControl_L_1)
                {
                    doorLeft.ActiveDoor();
                }

                if (hit.collider == LightControl_R_1)
                {
                    Debug.Log("LightControlRight");
                }

                if (hit.collider == DoorControl_R_1)
                {
                    doorRight.ActiveDoor();
                }

            }
        }
    }
}
