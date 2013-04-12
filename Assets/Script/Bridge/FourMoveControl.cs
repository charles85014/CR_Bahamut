using UnityEngine;
using System.Collections;
using Phidgets;
public class FourMoveControl : MonoBehaviour {
    public GameObject[] MoveConveyor = new GameObject[4];
    public float ConveyorSpeed;
    public float Move01_Height, Move01_Low;
    public float Move02_Height, Move02_Low;
    public float Move03_Height, Move03_Low;
    public float Move04_Height, Move04_Low;
	// Use this for initialization
	void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {

        if (MoveConveyor[0].transform.position.z < Move01_Height)
        {
            if (Input.GetKey(KeyCode.A))
            {
                MoveConveyor[0].transform.position = new Vector3(MoveConveyor[0].transform.position.x, MoveConveyor[0].transform.position.y, MoveConveyor[0].transform.position.z + ConveyorSpeed * Time.deltaTime);
            }
        }
        if (MoveConveyor[0].transform.position.z > Move01_Low)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                MoveConveyor[0].transform.position = new Vector3(MoveConveyor[0].transform.position.x, MoveConveyor[0].transform.position.y, MoveConveyor[0].transform.position.z - ConveyorSpeed * Time.deltaTime);
            }
        }

        if (MoveConveyor[1].transform.position.z < Move02_Height)
        {
            if (Input.GetKey(KeyCode.D))
            {
                MoveConveyor[1].transform.position = new Vector3(MoveConveyor[1].transform.position.x, MoveConveyor[1].transform.position.y, MoveConveyor[1].transform.position.z + ConveyorSpeed * Time.deltaTime);
            }
        }
        if (MoveConveyor[1].transform.position.z > Move02_Low)
        {
            if (Input.GetKey(KeyCode.X))
            {
                MoveConveyor[1].transform.position = new Vector3(MoveConveyor[1].transform.position.x, MoveConveyor[1].transform.position.y, MoveConveyor[1].transform.position.z - ConveyorSpeed * Time.deltaTime);
            }
        }

        if (MoveConveyor[2].transform.position.z < Move03_Height)
        {
            if (Input.GetKey(KeyCode.I))
            {
                MoveConveyor[2].transform.position = new Vector3(MoveConveyor[2].transform.position.x, MoveConveyor[2].transform.position.y, MoveConveyor[2].transform.position.z + ConveyorSpeed * Time.deltaTime);
            }
        }
        if (MoveConveyor[2].transform.position.z > Move03_Low)
        {
            if (Input.GetKey(KeyCode.K))
            {
                MoveConveyor[2].transform.position = new Vector3(MoveConveyor[2].transform.position.x, MoveConveyor[2].transform.position.y, MoveConveyor[2].transform.position.z - ConveyorSpeed * Time.deltaTime);
            }
        }

        if (MoveConveyor[3].transform.position.z < Move04_Height)
        {
            if (Input.GetKey(KeyCode.P))
            {
                MoveConveyor[3].transform.position = new Vector3(MoveConveyor[3].transform.position.x, MoveConveyor[3].transform.position.y, MoveConveyor[3].transform.position.z + ConveyorSpeed * Time.deltaTime);
            }
        }
        if (MoveConveyor[3].transform.position.z > Move04_Low)
        {
            if (Input.GetKey(KeyCode.L))
            {
                MoveConveyor[3].transform.position = new Vector3(MoveConveyor[3].transform.position.x, MoveConveyor[3].transform.position.y, MoveConveyor[3].transform.position.z - ConveyorSpeed * Time.deltaTime);
            }
        }
	}
   
}
