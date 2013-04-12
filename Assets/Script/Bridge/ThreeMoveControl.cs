using UnityEngine;
using System.Collections;

public class ThreeMoveControl : MonoBehaviour {
    public GameObject[] MoveConveyor = new GameObject[3];
    
    public float[] phidgetvalue;
    public float Move01_Height, Move01_Low;
    public float Move02_Height, Move02_Low;
    public float Move03_Height, Move03_Low;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        
        MoveConveyor[0].transform.position = new Vector3(MoveConveyor[0].transform.position.x, MoveConveyor[0].transform.position.y, Move01_Height - phidgetvalue[0] / 999 * Move01_Low);
        MoveConveyor[1].transform.position = new Vector3(MoveConveyor[1].transform.position.x, MoveConveyor[1].transform.position.y, Move02_Height - phidgetvalue[1] / 999 * Move02_Low);
        MoveConveyor[2].transform.position = new Vector3(MoveConveyor[2].transform.position.x, MoveConveyor[2].transform.position.y, Move03_Height - phidgetvalue[2] / 999 * Move03_Low);
	}
   
}
