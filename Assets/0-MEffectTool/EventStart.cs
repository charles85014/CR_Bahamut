using UnityEngine;
using System.Collections;

public class EventStart : MonoBehaviour {

    public GameObject PreGameStartGameObject;
	// Use this for initialization
	void Start () {
        PreGameStartGameObject.SetActive(false);
        Destroy(this);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
