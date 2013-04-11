using UnityEngine;
using System.Collections;

public class FruitShake : MonoBehaviour {
    int RoCount, PoCount;
	// Use this for initialization
	void Start () {
        RoCount = 1;
        PoCount = 1;
	}
    void ChangRo() {
        RoCount = -RoCount;
    }
    void ChangPo() {
        PoCount = -PoCount;
    }
	// Update is called once per frame
	void Update () {
        if (RoCount == 1)
            this.transform.Rotate(0, 0, 10 * Time.deltaTime);
        else if (RoCount == -1)
            this.transform.Rotate(0, 0, -10 * Time.deltaTime);
        if (!IsInvoking("ChangRo")) {
            Invoke("ChangRo", 0.3f);
        }

        if (PoCount == 1)
            this.transform.Translate(0, 0.2f * Time.deltaTime,0 );
        else if (PoCount == -1)
            this.transform.Translate(0, -0.2f * Time.deltaTime, 0);
        if (!IsInvoking("ChangPo"))
        {
            Invoke("ChangPo", 0.5f);
        }

	}
}
