using UnityEngine;
using System.Collections;

public class DeadLine : MonoBehaviour {
    public AudioSource ObjDropAudio;
	// Use this for initialization
	void Start () {
        ObjDropAudio = GameObject.Find("ObjDrop").GetComponent<AudioSource>();
	}
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.name == "DeadLine")
        {
            Destroy(gameObject);
            ObjDropAudio.Play();
        }
      


    }
	// Update is called once per frame
	void Update () {
	
	}
}
