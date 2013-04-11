using UnityEngine;
using System.Collections;

public class T_Conveyor : MonoBehaviour {
    ReGui ObjSpeed;
    public int ConveyorT;
	// Use this for initialization
	void Start () {
        ObjSpeed = GameObject.Find("ReST_GUIValue").GetComponent<ReGui>();
	}
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.name == "ConveyorTrigger")
        {
            ConveyorT = 1;
            }
        else
            ConveyorT = 0;
     

    }
	// Update is called once per frame
	void Update () {
	 
           if(ConveyorT == 1)
               this.transform.position = new Vector3(this.transform.position.x + ObjSpeed.ObjSpeed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
        
	}
}
