using UnityEngine;
using System.Collections;

public class FruitDestory : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    void fruitdestory() {
        Destroy(this.gameObject);
    }
	// Update is called once per frame
	void Update () {
        if (!IsInvoking("fruitdestory")) {
            Invoke("fruitdestory", 6);
        }
	}
}
