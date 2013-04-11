using UnityEngine;
using System.Collections;
using Phidgets;
public class FourMoveControl : MonoBehaviour {
    public GameObject[] MoveConveyor = new GameObject[4];
    InterfaceKit ifKit;
    public float[] phidgetvalue;
    public float Move01_Height, Move01_Distence;
    public float Move02_Height, Move02_Distence;
    public float Move03_Height, Move03_Distence;
    public float Move04_Height, Move04_Distence;
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
            phidgetvalue[0] = ifKit.sensors[0].Value;
            phidgetvalue[1] = ifKit.sensors[1].Value;
            phidgetvalue[2] = ifKit.sensors[2].Value;
            phidgetvalue[3] = ifKit.sensors[3].Value;
        }
        MoveConveyor[0].transform.position = new Vector3(MoveConveyor[0].transform.position.x, MoveConveyor[0].transform.position.y, Move01_Height - phidgetvalue[0] / 999 * Move01_Distence);
        MoveConveyor[1].transform.position = new Vector3(MoveConveyor[1].transform.position.x, MoveConveyor[1].transform.position.y, Move02_Height - phidgetvalue[1] / 999 * Move02_Distence);
        MoveConveyor[2].transform.position = new Vector3(MoveConveyor[2].transform.position.x, MoveConveyor[2].transform.position.y, Move03_Height - phidgetvalue[2] / 999 * Move03_Distence);
        MoveConveyor[3].transform.position = new Vector3(MoveConveyor[3].transform.position.x, MoveConveyor[3].transform.position.y, Move04_Height - phidgetvalue[3] / 999 * Move04_Distence);
	
	}
    void OnDisable()
    {
        this.ifKit.close();
    }
}
