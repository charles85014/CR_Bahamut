using UnityEngine;
using System.Collections;

public class MonkeyGui : MonoBehaviour {
   
    public GUIStyle MonScore, MonTime, BananaS, DurianS;
    public float M_TimeCounter;
    public int M_Score;
    public int Banana_Counter, Durian_Counter, MonkeyPass_Counter;
    public float MonkeyChangPic, MoreMonkeyChangPic;
    public float MonkeySpeed,MoreMonkeySpeed;
    public float MonkeyCreatRate, MoreMonkeyCreatRate;
    public float BanaCreatRate, MoreBanaCreatRate;
    public float DuriCreatRate, MoreDuriCreatRate;
    public bool TimeCheck_Mon = false;
    
	// Use this for initialization
	void Start () {
        M_TimeCounter = 60;
        M_Score = 0;
        Banana_Counter = 0;
        Durian_Counter = 0;
        MonkeyPass_Counter = 0;
        TimeCheck_Mon = false;
	}

   
	// Update is called once per frame
	void Update () {
        if (TimeCheck_Mon == true)
        {
            if (M_TimeCounter > 0)
                M_TimeCounter -= Time.deltaTime;
            if (M_TimeCounter < 20)
            {
                MonkeyChangPic = MoreMonkeyChangPic;
                MonkeySpeed = MoreMonkeySpeed;
                MonkeyCreatRate = MoreMonkeyCreatRate;
                BanaCreatRate = MoreBanaCreatRate;
                DuriCreatRate = MoreDuriCreatRate;

            }
            M_Score = Banana_Counter * 50 - Durian_Counter * 30 + MonkeyPass_Counter * 15;
            if (M_Score < 0)
                M_Score = 0;
        }
	}
}
