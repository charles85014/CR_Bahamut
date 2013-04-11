using UnityEngine;
using System.Collections;

public class TrapCreat01 : MonoBehaviour {
    public GameObject[] TrapCreat;
    public IcebergGui Ice_TrapRate;
    int ObjRandomNum,  TrapPosChance, Twice;
    float TrapPos;
	// Use this for initialization
	void Start () {
        Ice_TrapRate = GameObject.Find("IcebergGui").GetComponent<IcebergGui>();
	}
    void CreatTrap() {
        ObjRandomNum = Random.Range(1, 3);
        if (ObjRandomNum == 0)
        { 
            TrapPos = Random.Range(-6,1);
            Instantiate(TrapCreat[0], new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, TrapPos), TrapCreat[0].transform.rotation);
        }
        else if (ObjRandomNum == 1)
        {
            TrapPos = Random.Range(-6.8f,-0.8f);
            Instantiate(TrapCreat[1], new Vector3(this.gameObject.transform.position.x,this.gameObject.transform.position.y, TrapPos), TrapCreat[1].transform.rotation);

            if(TrapPos > -2){
                Twice = Random.Range(0, 2);
                if(Twice == 1)
                    Instantiate(TrapCreat[1], new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, TrapPos - 4.5f), TrapCreat[1].transform.rotation);
            }

            if (TrapPos < -5) {
                Twice = Random.Range(0, 2);
                if (Twice == 1)
                    Instantiate(TrapCreat[1], new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, TrapPos + 4.5f), TrapCreat[1].transform.rotation);
            }
        }
        else if (ObjRandomNum == 2) 
        {
            TrapPosChance = Random.Range(0, 2);
            if(TrapPosChance == 0)
                Instantiate(TrapCreat[2], new Vector3(this.gameObject.transform.position.x,this.gameObject.transform.position.y, -2.3f), TrapCreat[2].transform.rotation);
            else if (TrapPosChance == 1)
                Instantiate(TrapCreat[2], new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, -5.4f), TrapCreat[2].transform.rotation);
        }
    }
	// Update is called once per frame
	void Update () {
        if (!IsInvoking("CreatTrap"))
            Invoke("CreatTrap", Ice_TrapRate.TrapCreatRate);
	}
}
