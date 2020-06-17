using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLight : MonoBehaviour
{
    public GameObject LightLeft;
    public GameObject LightRight;


    // Start is called before the first frame update
    void Start()
    {
        LightLeft.SetActive(false);
        LightRight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            LightLeft.SetActive(!LightLeft.activeSelf);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            LightRight.SetActive(!LightRight.activeSelf);
        }
    }
}
