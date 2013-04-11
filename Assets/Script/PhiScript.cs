using UnityEngine;
using System.Collections;
using Phidgets;

public class PhiScript : MonoBehaviour {

    InterfaceKit ifKit;
    public float phidgetvalue;
    public int PortNumber = 0;

	// Use this for initialization
	void Start () {
        ifKit = new InterfaceKit();
        ifKit.open();
        ifKit.waitForAttachment(1000);
        
	}
 
	// Update is called once per frame
	void Update () {
        if (ifKit != null)
        {
            phidgetvalue = ifKit.sensors[PortNumber].Value;
        }
	}
    void OnDisable() {
        this.ifKit.close();
    }
}
