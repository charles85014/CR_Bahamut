using UnityEngine;
using System.Collections;

public class ReGui : MonoBehaviour {
   
    public float TimeCounter = 60;//­Ë¼Æ®É¶¡
    public int ReScore;
    public float ObjSpeed = 0.03f;
    public float ObjCreatRate = 3;
    public float MoreObjSpeed = 0.05f;
    public float MoreObjCreatRate = 2.3f;
    private ReScoreCounter[] ReSct;
    public GameObject[] ReRB;
    public bool TimeCheck = false;
 
    
	// Use this for initialization
	void Start () {
        TimeCounter = 60;
        ReScore = 0;
        TimeCheck = false;
        ReSct = new ReScoreCounter[ReRB.Length];
        this.ReSct[0] = ReRB[0].GetComponent<ReScoreCounter>();
        this.ReSct[1] = ReRB[1].GetComponent<ReScoreCounter>();
        this.ReSct[2] = ReRB[2].GetComponent<ReScoreCounter>();
	}
    
	// Update is called once per frame
	void Update () {
        if (TimeCounter > 0 && TimeCheck == true)
            TimeCounter -= Time.deltaTime;
       // print(ReSCt_CD.RightCount  +""+  ReSCt_Paper.RightCount +""+  ReSCt_Battery.RightCount);
        ReScore = (ReSct[0].RightCount + ReSct[1].RightCount + ReSct[2].RightCount) * 50;
        if (TimeCounter < 20 )
        {
            ObjSpeed = MoreObjSpeed;
            ObjCreatRate = MoreObjCreatRate;
        }
	}
}
