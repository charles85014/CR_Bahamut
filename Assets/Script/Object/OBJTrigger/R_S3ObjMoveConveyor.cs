using UnityEngine;
using System.Collections;

public class R_S3ObjMoveConveyor : MonoBehaviour{
    public int RS1_MoveY = 0;
    float Zdis = 0, ZdisTwo = 0;
    public GameObject MoveConveyor01, MoveConveyor02, MoveConveyor03, MoveConveyor04;
    StageData Stage_data;
    ReGui ObjSpeed;

	// Use this for initialization
	void Start () {
        Stage_data = GameObject.Find("StageData").GetComponent<StageData>();

        if (Stage_data.StageCount == 3 && Stage_data.Stage_name.ToString() == "Recycle")
            this.gameObject.GetComponent<R_S3ObjMoveConveyor>().enabled = true;
        else
            this.gameObject.GetComponent<R_S3ObjMoveConveyor>().enabled = false;

        MoveConveyor01 = GameObject.Find("MoveConveyor01");
        MoveConveyor02 = GameObject.Find("MoveConveyor02");
        MoveConveyor03 = GameObject.Find("MoveConveyor03");
        MoveConveyor04 = GameObject.Find("MoveConveyor04");
        ObjSpeed = GameObject.Find("ReST_GUIValue").GetComponent<ReGui>();
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "MoveConveyorTrigger01")
        {
            Zdis = this.gameObject.transform.position.z - MoveConveyor01.transform.position.z;
        }
        if (other.gameObject.name == "MoveConveyorTrigger02")
        {
            Zdis = this.gameObject.transform.position.z - MoveConveyor02.transform.position.z;
        }
        if (other.gameObject.name == "MoveConveyorTrigger03")
        {
            ZdisTwo = this.gameObject.transform.position.z - MoveConveyor03.transform.position.z;
        }
        if (other.gameObject.name == "MoveConveyorTrigger04")
        {
            ZdisTwo = this.gameObject.transform.position.z - MoveConveyor04.transform.position.z;
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
        else if (other.gameObject.name == "MoveConveyorTrigger03")
        {
            RS1_MoveY = 3;
        }
        else if (other.gameObject.name == "MoveConveyorTrigger04")
        {
            RS1_MoveY = 4;
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
        if (RS1_MoveY == 3)
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + ObjSpeed.ObjSpeed * Time.deltaTime, this.gameObject.transform.position.y, MoveConveyor03.transform.position.z + ZdisTwo);
        }
        if (RS1_MoveY == 4)
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + ObjSpeed.ObjSpeed * Time.deltaTime, this.gameObject.transform.position.y, MoveConveyor04.transform.position.z + ZdisTwo);
        }
	}
}
