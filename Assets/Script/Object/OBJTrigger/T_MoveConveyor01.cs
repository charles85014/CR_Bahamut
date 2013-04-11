using UnityEngine;
using System.Collections;

public class T_MoveConveyor01 : MonoBehaviour {
    int MoveYNum01 = 0;
   
    // Use this for initialization
    void Start()
    {
       
    }
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.name == "MoveConveyorTrigger01")
        {
            this.transform.position += new Vector3(0.03f, 0, 0);
            MoveYNum01 = 1;

        }
        else
        {
            MoveYNum01 = 0;
        }


    }
    // Update is called once per frame
    void Update()
    {

        if (MoveYNum01 == 1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                this.transform.Translate(Vector3.up);
            }
            if (Input.GetKey(KeyCode.S))
            {
                this.transform.Translate(Vector3.down);
            }
        }
    }
}
