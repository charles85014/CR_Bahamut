using UnityEngine;
using System.Collections;

public class M_TreeTop : MonoBehaviour {
    MonkeyGui MonSpeed;
    public int TreeTopT;
	// Use this for initialization
	void Start () {
        MonSpeed = GameObject.Find("MonkeyGui").GetComponent<MonkeyGui>();
	}
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.name == "LTTTrigger" || other.gameObject.name == "TreeTopTrigger")
        {
            TreeTopT = 1;
        }
        else
            TreeTopT = 0;


    }
	// Update is called once per frame
	void Update () {
        if (TreeTopT == 1)
            this.transform.position = new Vector3(this.transform.position.x + MonSpeed.MonkeySpeed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
        
	}
}
