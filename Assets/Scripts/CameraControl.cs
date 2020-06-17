using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public bool isRotating = false;
    public float timeToPause = 1.0f;

    public Transform startTransform;
    public Transform endTransform;

    public float speed;

    protected Quaternion startAngle;

    [SerializeField]
    protected bool currentDirection = true;

    void Start()
    {
        startAngle = transform.rotation;

        if(isRotating)
        StartCoroutine("CameraRotation");
    }

    IEnumerable CameraRotation()
    {
        while (true)
        {
            if (currentDirection)
            {
                if (Vector3.Dot(transform.forward, startTransform.forward) >= 0.9f)
                {
                    Debug.Log("currentDirectionTrue: " + Vector3.Dot(transform.forward, startTransform.forward).ToString());
                    currentDirection = !currentDirection;
                    yield return new WaitForSeconds(timeToPause);
                }
                else
                {
                    Debug.Log("Paused");
                    transform.rotation = Quaternion.Slerp(transform.rotation, startTransform.rotation, Time.time * speed);
                    yield return null;
                }
            }

            else
            {
                if (Vector3.Dot(transform.forward, startTransform.forward) >= 0.9f)
                {
                    Debug.Log("Paused");
                    currentDirection = !currentDirection;
                    yield return new WaitForSeconds(timeToPause);
                }
                else
                {
                    Debug.Log("currentDirectionFalse: " + Vector3.Dot(transform.forward, startTransform.forward).ToString());
                    transform.rotation = Quaternion.Slerp(transform.rotation, endTransform.rotation, Time.time * speed);
                    yield return null;
                }
                
            }
        }
    }

    // Update is called once per frame
   
}
