using UnityEngine;
using System.Collections;

public class TrapXMove : MonoBehaviour {
    public IcebergGui IceTrapSpeed;
    public float TrapSpeedConstant;
	// Use this for initialization
	void Start () {
        IceTrapSpeed = GameObject.Find("IcebergGui").GetComponent<IcebergGui>();
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x - IceTrapSpeed.IceRoadRate * TrapSpeedConstant * Time.deltaTime, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
	}
}
