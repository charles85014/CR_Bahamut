using UnityEngine;
using System.Collections;
using Firmata.NET;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    private Arduino arduino;

    private int value;
    private int analogValue;
    private bool isLight;

    // Use this for initialization
    void Start()
    {
        this.arduino = new Arduino("COM3", 57600);      // New a Arduino Object
        this.arduino.Open();            // Open the Port "COM3"
        //this.arduino.pinMode(13, Arduino.OUTPUT);
        this.arduino.pinMode(11, Arduino.INPUT);
        this.isLight = false;
    }

    // Update is called once per frame
    void Update()
    {
        value = this.arduino.digitalRead(11);
        this.analogValue = this.arduino.analogRead(1);
        this.light.intensity = this.analogValue / 1023.0f * 8;

        if (this.isLight)
        {
            this.arduino.digitalWrite(13, Arduino.HIGH);
            this.light.enabled = true;
        }
        else
        {
            this.arduino.digitalWrite(13, Arduino.LOW);
            this.light.enabled = false;
        }
        print(this.value);
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(300, 400, 100, 50), "Light Switch"))
        {
            this.isLight = !this.isLight;
        }

        if (value > 0)
            this.isLight = !this.isLight;
    }

    void OnApplicationQuit()
    {
        this.arduino.Close();           // Close the Port "COM3"
    }
}
