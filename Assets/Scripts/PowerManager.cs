using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerManager : MonoBehaviour
{
    public static PowerManager Instance { get; private set; }

    float powerSink = 0.1f;

    public float Charge { get; private set; }

    protected Power[] poweredObjects;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        Charge = 100.0f;
        poweredObjects = FindObjectsOfType<Power>();
    }

    void OnGUI()
    {
        GUILayout.Label(Charge.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        Charge -= powerSink * Time.deltaTime;

        if(Charge <= 0.0f)
        {
            Charge = 0.0f;
            foreach(var poweredItem in poweredObjects)
            {
                poweredItem.OnPowerOutage();
            }
            this.enabled = false;
        }
    }

    public void UsePower(Power poweredObject)
    {
        powerSink += poweredObject.wattage;
    }

    public void ReleasePower(Power poweredObject)
    {
        powerSink -= poweredObject.wattage;
    }
}
