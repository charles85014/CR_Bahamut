using UnityEngine;
using System.Collections;

public class T_MoveConveyor02 : MonoBehaviour {
    int MoveYNum02 = 0;
  
    // Use this for initialization
    void Start()
    {
      
    }
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.name == "MoveConveyorTrigger02")
        {
            this.transform.position += new Vector3(0.03f, 0, 0);
            MoveYNum02 = 1;

        }
        else
        {
            MoveYNum02 = 0;
        }


    }
    // Update is called once per frame
    void Update()
    {

        if (MoveYNum02 == 1)
        {
            if (Input.GetKey("up"))
            {
                this.transform.Translate(Vector3.up);
            }
            if (Input.GetKey("down"))
            {
                this.transform.Translate(Vector3.down);
            }
        }
    }
}
