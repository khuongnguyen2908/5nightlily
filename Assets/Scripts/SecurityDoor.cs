using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityDoor : MonoBehaviour
{
    public float DoorHeight = 2.12f;
    public float DoorSpeed = 1.0f;

    public bool DoorInUse = false;
    public bool DoorOpen = false;

    IEnumerator openDoor()
    {

        for (float amount = 0.0f; amount < DoorHeight; amount += DoorSpeed * Time.deltaTime)
        {
            Debug.Log("Opening Door: " + amount.ToString());
            transform.position = new Vector3(transform.position.x, amount, transform.position.z);
            yield return null;
        }
        transform.position = new Vector3(transform.position.x, DoorHeight, transform.position.z);

        DoorInUse = false;
        DoorOpen = true;
    }

    IEnumerator closeDoor()
    {
        for (float amount = DoorHeight; amount > 0.0f; amount -= DoorSpeed * Time.deltaTime)
        {
            Debug.Log("Closing Door: " + amount.ToString());
            transform.position = new Vector3(transform.position.x, amount, transform.position.z);
            yield return null;
        }
        transform.position = new Vector3(transform.position.x, 0.0f, transform.position.z);
        DoorInUse = false;
        DoorOpen = false;
    }
   
    public void ActiveDoor()
    {
        if (DoorInUse)
        {
            DoorInUse = true;
            if (DoorOpen)
                StartCoroutine("closeDoor");
            else
                StartCoroutine("openDoor");
        }
    }

}
