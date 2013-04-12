using UnityEngine;
using System.Collections;

public class StartGUI : MonoBehaviour {
    public AudioSource NormalButton, StageButton;
    public GUIStyle StartS, ExitS, BackS, RecycleS, MonkeyS, IcebergS,re01,re02,re03;
    public int ChangGUI=0;
    public float T1w_up, T1w_down, T1h_up, T1h_down;
    public float T2w_up, T2w_down, T2h_up, T2h_down;
    public float T3w_up, T3w_down, T3h_up, T3h_down;
    public float T4w_up, T4w_down, T4h_up, T4h_down;
    public float T5w_up, T5w_down, T5h_up, T5h_down;
    public float T6w_up, T6w_down, T6h_up, T6h_down;
    public float T7w_up, T7w_down, T7h_up, T7h_down;
    public float T8w_up, T8w_down, T8h_up, T8h_down;
    public float T9w_up, T9w_down, T9h_up, T9h_down;

    public float S1_w, S1_h, S2_w, S2_h,S3_w,S3_h;
	// Use this for initialization
	void Start () {
        ChangGUI = 0;
	}
    void OnGUI() {
        if (ChangGUI == 0)
        {
            if (GUI.Button(new Rect(Screen.width * T1w_up / T1w_down,Screen.height * T1h_up / T1h_down,Screen.width * S1_w,Screen.height * S1_h),"",StartS))
            {
                ChangGUI = 1;
                NormalButton.Play();
            }
            if (GUI.Button(new Rect(Screen.width * T2w_up / T2w_down, Screen.height * T2h_up / T2h_down,Screen.width * S1_w,Screen.height * S1_h),"",ExitS))
            {
                NormalButton.Play();
                Application.Quit();
            }
        }
        if (ChangGUI == 1) {
            if (GUI.Button(new Rect(Screen.width * T3w_up / T3w_down, Screen.height * T3h_up / T3h_down, Screen.width * S1_w, Screen.height * S1_h),"",BackS))
            {
                NormalButton.Play();
                ChangGUI = 0;
            }
            if (GUI.Button(new Rect(Screen.width * T4w_up / T4w_down, Screen.height * T4h_up / T4h_down, Screen.width * S2_w, Screen.height * S2_h),"",RecycleS))
            {
                StageButton.Play();
                ChangGUI = 2;
                
            }
            if (GUI.Button(new Rect(Screen.width * T5w_up / T5w_down, Screen.height * T5h_up / T5h_down, Screen.width * S2_w, Screen.height * S2_h),"",MonkeyS))
            {
                StageButton.Play();
                if (!IsInvoking("MoStage"))
                {
                    Invoke("MoStage", 1);
                }
              
            }
            if (GUI.Button(new Rect(Screen.width * T6w_up / T6w_down, Screen.height * T6h_up / T6h_down, Screen.width * S2_w, Screen.height * S2_h),"",IcebergS))
            {
                StageButton.Play();
                if (!IsInvoking("IceStage"))
                {
                    Invoke("IceStage", 1);
                }
           
            }
        }
        if (ChangGUI == 2) {
            if (GUI.Button(new Rect(Screen.width * T3w_up / T3w_down, Screen.height * T3h_up / T3h_down, Screen.width * S1_w, Screen.height * S1_h), "", BackS))
            {
                NormalButton.Play();
                ChangGUI = 1;
            }
            if (GUI.Button(new Rect(Screen.width * T4w_up / T4w_down, Screen.height * T4h_up / T4h_down, Screen.width * S3_w, Screen.height * S3_h), "", re01))
            {
                StageButton.Play();
                if (!IsInvoking("ReStage01"))
                {
                    Invoke("ReStage01", 1);
                }

            }
            if (GUI.Button(new Rect(Screen.width * T5w_up / T5w_down, Screen.height * T5h_up / T5h_down, Screen.width * S3_w, Screen.height * S3_h), "", re02))
            {
                StageButton.Play();
                if (!IsInvoking("ReStage02"))
                {
                    Invoke("ReStage02", 1);
                }

            }
            if (GUI.Button(new Rect(Screen.width * T6w_up / T6w_down, Screen.height * T6h_up / T6h_down, Screen.width * S3_w, Screen.height * S3_h), "", re03))
            {
                StageButton.Play();
                if (!IsInvoking("ReStage03"))
                {
                    Invoke("ReStage03", 1);
                }

            }
        
        }
        
    }
    void ReStage01() {
        Application.LoadLevel("R_01");
    }
    void ReStage02()
    {
        Application.LoadLevel("R_02");
    }
    void ReStage03()
    {
        Application.LoadLevel("R_03");
    }
    void MoStage()
    {
        Application.LoadLevel("Monkey01");
    }
    void IceStage()
    {
        Application.LoadLevel("Iceberg01");
    }
	// Update is called once per frame
	void Update () {
	
	}
}
