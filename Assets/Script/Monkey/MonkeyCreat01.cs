using UnityEngine;
using System.Collections;

public class MonkeyCreat01 : MonoBehaviour {
    public AudioSource MoukeyInAudio;
    public GameObject MonkeyCreat;
    public MonkeyGui MonkeyCreatRate;
    int MonkeyZ;
	// Use this for initialization
	void Start () {
        MonkeyCreatRate = GameObject.Find("MonkeyGui").GetComponent<MonkeyGui>();
        MoukeyInAudio = GameObject.Find("MonkeyInAudio").GetComponent<AudioSource>();
	}
    void CreatMonkey() { 
        MonkeyZ = Random.Range(-6,2);
        Instantiate(MonkeyCreat, new Vector3(-17, 9.5f, MonkeyZ), MonkeyCreat.transform.rotation);
        MoukeyInAudio.Play();
    }
	// Update is called once per frame
	void Update () {
        if (!IsInvoking("CreatMonkey")) {
            Invoke("CreatMonkey", MonkeyCreatRate.MonkeyCreatRate);
        }
	}
}
