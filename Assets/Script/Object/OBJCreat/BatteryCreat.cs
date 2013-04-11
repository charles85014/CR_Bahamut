using UnityEngine;
using System.Collections;

public class BatteryCreat : MonoBehaviour {
    public AudioSource ObjInAudio;
    ReGui ObjCreatRate;
   public GameObject[] ObjCreat;
   public float Xseat;
   public float Yseat;
   public float[] Zseat;
    int i = 0 , j = 0; // random number

	// Use this for initialization
	void Start () {
        ObjCreatRate = GameObject.Find("ReST_GUIValue").GetComponent<ReGui>();
	}
    void CreatOBJ()
    {
        i = Random.Range(0, ObjCreat.Length);//Object random
        j = Random.Range(0, Zseat.Length);//Seat random
        Instantiate(ObjCreat[i], new Vector3(Xseat, Yseat - 1, Zseat[j]), ObjCreat[i].transform.rotation);
        ObjInAudio.Play();
    }
	// Update is called once per frame
	void Update () {

      
        if (!IsInvoking("CreatOBJ"))
        {
            Invoke("CreatOBJ", ObjCreatRate.ObjCreatRate);      
        }
	}
}
