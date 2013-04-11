using UnityEngine;
using System.Collections;

public class ThreeTwoOne : MonoBehaviour {
    public AudioSource ThreeTwoOneAudio, GoAudio;
    public GameObject StageGUI;
    public GameObject CreatObj;
    public GameObject EndPlane;
   // public int CTWup, CTWdown, CTHup, CTHdown, CT_GH, CT_GW,CT_FontSize;
    public GUIStyle CTStyle;
    public GameObject TimeBackPlane;
    public Texture[] TimeBackCt;
    float TimeCount;
	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        this.gameObject.SetActive(true);
        EndPlane.gameObject.SetActive(false);
        TimeCount = 0;
        StageGUI.gameObject.SetActive(false);
        CreatObj.gameObject.SetActive(false);
        TimeBackPlane.gameObject.SetActive(false);
  
	}
    void TimeBack() {
        TimeCount++;
        print(TimeCount);
        if (TimeCount == 3) {
            TimeBackPlane.gameObject.SetActive(true);
            TimeBackPlane.gameObject.renderer.material.mainTexture = TimeBackCt[0];
            ThreeTwoOneAudio.Play();
        }
        if (TimeCount == 4)
        {
            TimeBackPlane.gameObject.renderer.material.mainTexture = TimeBackCt[1];
            ThreeTwoOneAudio.Play();
        }
        if (TimeCount == 5)
        {
            TimeBackPlane.gameObject.renderer.material.mainTexture = TimeBackCt[2];
            ThreeTwoOneAudio.Play();
        }
        if (TimeCount == 6)
        {
            TimeBackPlane.gameObject.renderer.material.mainTexture = TimeBackCt[3];
            GoAudio.Play();
        }
        if (TimeCount == 7)
        {
            StageGUI.gameObject.SetActive(true);
            
            CreatObj.gameObject.SetActive(true);
            TimeBackPlane.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
	// Update is called once per frame
	void Update () {
        if (!IsInvoking("TimeBack")) {
            Invoke("TimeBack",1);
        }
	}
}
