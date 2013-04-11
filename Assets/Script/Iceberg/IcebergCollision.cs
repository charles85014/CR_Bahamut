using UnityEngine;
using System.Collections;

public class IcebergCollision : MonoBehaviour {
    public AudioSource PenguinDropAudio;
    public IcebergGui P_IceGui;
    public IcebergGameOverGui P_IceGameOverGui;
    public GameObject PenguinStayPlace;
	// Use this for initialization
	void Start () {
        P_IceGui = GameObject.Find("IcebergGui").GetComponent<IcebergGui>();
        P_IceGameOverGui = GameObject.Find("IcebergGameOverGui").GetComponent<IcebergGameOverGui>();
        PenguinStayPlace = GameObject.Find("PenguinStay01");
        PenguinDropAudio = GameObject.Find("ObjDrop").GetComponent<AudioSource>();
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PenguinMove01" || other.gameObject.name == "PenguinMove02")
        {
            PenguinDropAudio.Play();
            other.gameObject.transform.position = new Vector3(PenguinStayPlace.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
            if (P_IceGui.PenguinCounter > 0)
                P_IceGui.PenguinCounter--;
            P_IceGameOverGui.PenguinDefeatCount--;
            
        }

    }
	// Update is called once per frame
	void Update () {
	
	}
}
