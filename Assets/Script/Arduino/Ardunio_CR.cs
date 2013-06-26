using UnityEngine;
using System.Collections;
using Firmata.NET;

public class Ardunio_CR : MonoBehaviour {

    private Arduino arduino;
    private int analogValue;
	// Use this for initialization
	void Start () {
        this.arduino = new Arduino("COM8", 57600);      // New a Arduino Object
        this.arduino.Open();            // Open the Port "COM3"
	}
	
	// Update is called once per frame
	void Update () {
        this.analogValue = this.arduino.analogRead(1);
        print(analogValue / 1023.0f * 8);
	}

    void OnApplicationQuit()
    {
        this.arduino.Close();           // Close the Port "COM3"
    }
}
