using UnityEngine;
using System.Collections;

public class R_S1ObjMoveConveyor : MonoBehaviour {
   public int RS1_MoveY = 0;
    float Zdis = 0;
    public GameObject MoveConveyor01,MoveConveyor02;
    StageData Stage_data;
    ReGui ObjSpeed;
	// Use this for initialization
	void Start () {

        Stage_data = GameObject.Find("StageData").GetComponent<StageData>();
        
        if (Stage_data.StageCount == 1 && Stage_data.Stage_name.ToString() == "Recycle" )
            this.gameObject.GetComponent<R_S1ObjMoveConveyor>().enabled = true;
        else
            this.gameObject.GetComponent<R_S1ObjMoveConveyor>().enabled = false;

        MoveConveyor01 = GameObject.Find("MoveConveyor01");
        MoveConveyor02 = GameObject.Find("MoveConveyor02");
        ObjSpeed = GameObject.Find("ReST_GUIValue").GetComponent<ReGui>();
	}
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "MoveConveyorTrigger01" )
        {
            Zdis = this.gameObject.transform.position.z - MoveConveyor01.transform.position.z;
        }
        if ( other.gameObject.name == "MoveConveyorTrigger02")
        {
            Zdis = this.gameObject.transform.position.z - MoveConveyor02.transform.position.z;
        }
       
    }
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.name == "MoveConveyorTrigger01")
        {      
            RS1_MoveY = 1;        
        }
        else if (other.gameObject.name == "MoveConveyorTrigger02")
        {
            RS1_MoveY = 2;
        }
        else
            RS1_MoveY = 0;
       
    }
	// Update is called once per frame
	void Update () {

        if (RS1_MoveY == 1)
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + ObjSpeed.ObjSpeed * Time.deltaTime, this.gameObject.transform.position.y, MoveConveyor01.transform.position.z + Zdis);
        }
        if (RS1_MoveY == 2)
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + ObjSpeed.ObjSpeed * Time.deltaTime, this.gameObject.transform.position.y, MoveConveyor02.transform.position.z + Zdis);
        }
       
	}
}
