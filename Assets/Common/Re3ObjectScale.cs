using UnityEngine;
using System.Collections;

public class Re3ObjectScale : MonoBehaviour {
    public StageData stagedata;
	// Use this for initialization
	void Start () {
        stagedata = GameObject.Find("StageData").GetComponent<StageData>();
        if (stagedata.StageCount == 3)
            this.gameObject.transform.localScale = new Vector3(this.gameObject.transform.localScale.x * 0.7f,this.gameObject.transform.localScale.y * 0.7f,this.gameObject.transform.localScale.z * 0.7f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
