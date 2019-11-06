using UnityEngine;
using System.IO.Ports; // Need for Arduino Connection
public class ArduinoBehaviour : MonoBehaviour
{
    // First parameter is the COM-Port the arduino is connected
    // if you not sure which COM-Port, look into the device-manager on your computer
    // if your using a Mac you need to set the full Path to the serial instead of „COM3“
    // the second parameter is the port to listen
    SerialPort sp = new SerialPort("COM3", 9600);
    // Use this for initialization
    void Start()
    {
        // Opening the Port, once open this port is blocked for other applications
        if (!sp.IsOpen)
            sp.Open();
    }
    // Update is called once per frame
    void Update()
    {
        if (sp.IsOpen)
            Debug.Log(sp.ReadLine());
    }
    void OnApplicationQuit()
    {
        // Make sure to close the port in the end
        if (sp.IsOpen)
            sp.Close();
    }
}