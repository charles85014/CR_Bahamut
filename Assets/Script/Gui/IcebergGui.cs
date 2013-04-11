using UnityEngine;
using System.Collections;

public class IcebergGui : MonoBehaviour {
    public AudioSource ChangeRateAudio;

   
    public float I_TimeCounter;
    public int IceScore;
    public int PenguinCounter;
    public float IceRoadRate,RateRange;
    public int PenguinCount01, PenguinCount02;
    public int Penguin01_ScoreRange, Penguin02_ScoreRange;
    public float TrapCreatRate,TrapCreatRateRange;

    public bool TimeCheck_ice = false;
	// Use this for initialization
	void Start () {
        I_TimeCounter = 0;
        IceScore = 0;
        PenguinCounter = 3;
        PenguinCount01 = 0;
        PenguinCount02 = 0;
        Penguin01_ScoreRange = 10;
        Penguin02_ScoreRange = 15;
        TimeCheck_ice = false;
	}
    void RateRangeChamg() {
        ChangeRateAudio.Play();
        IceRoadRate += RateRange;
        TrapCreatRate -= TrapCreatRateRange;
        RateRange /= 2;
        TrapCreatRateRange /= 2;
        Penguin01_ScoreRange += 10;
        Penguin02_ScoreRange += 15;
        
    }
    
	// Update is called once per frame
	void Update () {
        if (TimeCheck_ice == true)
        {
            I_TimeCounter += Time.deltaTime;
            IceScore = PenguinCount01 * Penguin01_ScoreRange + PenguinCount02 * Penguin02_ScoreRange;
            if (!IsInvoking("RateRangeChamg"))
            {
                Invoke("RateRangeChamg", 20);
            }
        }
	}
}
