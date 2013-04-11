using UnityEngine;
using System.Collections;

public class M_S1MonkeyMove : MonoBehaviour {
    public int MS1_MoveY = 0;
    float MZdis = 0;
    public GameObject TreeTopMove01, TreeTopMove02;
    StageData Stage_data;
    MonkeyGui MObjSpeed;
	// Use this for initialization
	void Start () {

        Stage_data = GameObject.Find("StageData").GetComponent<StageData>();
        if (Stage_data.StageCount == 1 && Stage_data.Stage_name.ToString() == "Monkey")
            this.gameObject.GetComponent<M_S1MonkeyMove>().enabled = true;
        else
            this.gameObject.GetComponent<M_S1MonkeyMove>().enabled = false;
        TreeTopMove01 = GameObject.Find("TreeTopMove01");
        TreeTopMove02 = GameObject.Find("TreeTopMove02");
        MObjSpeed = GameObject.Find("MonkeyGui").GetComponent<MonkeyGui>();

	}

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "TreeTopMoveTrigger01")
        {
            MZdis = this.gameObject.transform.position.z - TreeTopMove01.transform.position.z;
        }
        if (other.gameObject.name == "TreeTopMoveTrigger02")
        {
            MZdis = this.gameObject.transform.position.z - TreeTopMove02.transform.position.z;
        }

    }
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.name == "TreeTopMoveTrigger01")
        {
            MS1_MoveY = 1;
        }
        else if (other.gameObject.name == "TreeTopMoveTrigger02")
        {
            MS1_MoveY = 2;
        }
        else
            MS1_MoveY = 0;

    }
	
	// Update is called once per frame
	void Update () {

        if (MS1_MoveY == 1)
        {
          
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + MObjSpeed.MonkeySpeed * Time.deltaTime, this.gameObject.transform.position.y,
                TreeTopMove01.transform.position.z + MZdis);
        }
        if (MS1_MoveY == 2)
        {
            
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + MObjSpeed.MonkeySpeed * Time.deltaTime, this.gameObject.transform.position.y,
                TreeTopMove02.transform.position.z + MZdis);
        }
	}
}
