using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScriptBasic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        Debug.Log("Number of web cams connected: " + devices.Length);
        Renderer rend = this.GetComponentInChildren<Renderer>();

        WebCamTexture mycam = new WebCamTexture();
        string camName = devices[0].name; // 0:laptop webcam, 1:Theta V/Z1 cam
        Debug.Log("The webcam name is " + camName);
        mycam.deviceName = camName;
        rend.material.mainTexture = mycam;

        mycam.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
