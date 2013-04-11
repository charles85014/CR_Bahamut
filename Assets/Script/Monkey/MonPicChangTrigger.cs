using UnityEngine;
using System.Collections;

public class MonPicChangTrigger : MonoBehaviour {
    public AudioSource EatBananaAudio, EatDurianAudio;
    public MonkeyGui FruitCount;
	// Use this for initialization
	void Start () {
        FruitCount = GameObject.Find("MonkeyGui").GetComponent<MonkeyGui>();
        EatBananaAudio = GameObject.Find("EatBanana").GetComponent<AudioSource>();
        EatDurianAudio = GameObject.Find("EatDurian").GetComponent<AudioSource>();
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Banana(Clone)")
        {
            EatBananaAudio.Play();
            FruitCount.Banana_Counter++;
         
            Destroy(other.gameObject);
            this.gameObject.GetComponent<NPicChang>().enabled = false;
            this.gameObject.GetComponent<DPicChang>().enabled = false;
            this.gameObject.GetComponent<BPicChang>().enabled = true;
        }
        else if (other.gameObject.name == "Durian(Clone)")
        {
            EatDurianAudio.Play();
            FruitCount.Durian_Counter++;
           
            Destroy(other.gameObject);
            this.gameObject.GetComponent<NPicChang>().enabled = false;
            this.gameObject.GetComponent<BPicChang>().enabled = false;
            this.gameObject.GetComponent<DPicChang>().enabled = true;
        }
        if (other.gameObject.name == "MonkeyPassRoad") {
            FruitCount.MonkeyPass_Counter++;
            Destroy(this.gameObject);
        }

    }
	// Update is called once per frame
	void Update () {
	
	}
}
