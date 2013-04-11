using UnityEngine;
using System.Collections;

public class ReScoreCounter : MonoBehaviour {
    public GameObject[] ReOBJWrong;
    public GameObject ReOBJRight;
    public AudioSource ObjRightAudio, ObjWrongAudio;
   
    public int RightCount;
  
    // Use this for initialization
    void Start()
    {
        RightCount = 0;

    }
    void OnCollisionEnter(Collision other)
    {
        foreach(GameObject obj in ReOBJWrong)
        {
            if (other.gameObject.name == obj.name + "(Clone)") {
                Destroy(other.gameObject);
                ObjWrongAudio.Play();
      
              }
        }
        
        if (other.gameObject.name == ReOBJRight.name + "(Clone)")
        {
            RightCount ++;
            Destroy(other.gameObject);
            ObjRightAudio.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
      
    }
}
