using UnityEngine;
using System.Collections;

public class Move_MoveConveyor02 : MonoBehaviour {
   
    GameObject MoveConveyor02;
	// Use this for initialization
	void Start () {
        MoveConveyor02 = GameObject.Find("MoveConveyor02");
	}
   
	// Update is called once per frame
	void Update () {

      
            if (Input.GetKey("up"))
            {
                this.transform.Translate(Vector3.forward);
            }
            if (Input.GetKey("down"))
            {
                this.transform.Translate(Vector3.back);
            }
        
	}
}
