using UnityEngine;
using System.Collections;

public class TrapDead : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (this.gameObject.transform.position.x < -17)
            Destroy(this.gameObject);
	}
}
