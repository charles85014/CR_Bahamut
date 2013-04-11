using UnityEngine;
using System.Collections;

public class Move_MoveConveyor01 : MonoBehaviour {


    GameObject MoveConveyor01;
    // Use this for initialization
    void Start()
    {
        MoveConveyor01 = GameObject.Find("MoveConveyor01");
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back);
        }

    }
}
