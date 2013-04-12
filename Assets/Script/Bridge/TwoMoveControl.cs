using UnityEngine;
using System.Collections;

public class TwoMoveControl : MonoBehaviour
{
    public GameObject[] MoveConveyor = new GameObject[2];
    public float ConveyorSpeed;

    public float Move01_Height, Move01_Low;
    public float Move02_Height, Move02_Low;
    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        print(MoveConveyor[0].transform.position.z);
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
            if (Input.GetKey(KeyCode.H))
            {
                MoveConveyor[1].transform.position = new Vector3(MoveConveyor[1].transform.position.x, MoveConveyor[1].transform.position.y, MoveConveyor[1].transform.position.z + ConveyorSpeed * Time.deltaTime);
            }
        }

        if (MoveConveyor[1].transform.position.z > Move02_Low)
        {
            if (Input.GetKey(KeyCode.B))
            {
                MoveConveyor[1].transform.position = new Vector3(MoveConveyor[1].transform.position.x, MoveConveyor[1].transform.position.y, MoveConveyor[1].transform.position.z - ConveyorSpeed * Time.deltaTime);
            }
        }
    }

}
