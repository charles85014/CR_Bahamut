using UnityEngine;
using System.Collections;

public class PictureAlphaFlicker : MonoBehaviour {
    float alpha;
    public Texture Controlnumber;
    public float flickerTime;
	// Use this for initialization
	void Start () {
        alpha = 1;
        this.renderer.material.mainTexture = Controlnumber;
	}
    void NumberFlicker() {
        if (alpha == 1)
        {
            alpha = 0;
            renderer.enabled = false;
        }
        else if (alpha == 0)
        {
            alpha = 1;
            renderer.enabled = true;
        }
            
    }
	// Update is called once per frame
	void Update () {
        if (!IsInvoking("NumberFlicker")) {
            Invoke("NumberFlicker", flickerTime);
        }
	}
}
