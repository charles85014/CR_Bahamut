using UnityEngine;
using System.Collections;

public class PenguinCollision : MonoBehaviour {
    public IcebergGui P_IceGui;
    public IcebergGameOverGui P_IceGameOverGui;
    public GameObject PenguinStayPlace;
  
    public float PenguinStayPosX01;
    public int PenguinReStaySpeed;
    public bool PenguinNoStayCount = true;
	// Use this for initialization
	void Start () {
     
            PenguinStayPosX01 = -8.5f;

	}
 /*   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Snowman(Clone)" || other.gameObject.name == "IceHoleBig(Clone)" || other.gameObject.name == "IceHoleS(Clone)")
        {
            this.gameObject.transform.position = new Vector3(PenguinStayPlace.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
            if (P_IceGui.PenguinCounter > 0)
                P_IceGui.PenguinCounter--;
            P_IceGameOverGui.PenguinDefeatCount--;
            print("BooM01");
        }
     
    }*/
    void PenguinNoStay() { 
          if(PenguinNoStayCount == true){
              this.gameObject.renderer.enabled = true;
              PenguinNoStayCount = false;
          }
          else if (PenguinNoStayCount == false) {
              this.gameObject.renderer.enabled = false;
              PenguinNoStayCount = true;
          }
    
    }

    void PenguinCounter() {
      
            P_IceGui.PenguinCount01++;
       
    }

	// Update is called once per frame
	void Update () {
        if (this.gameObject.transform.position.x < PenguinStayPosX01-0.05f)
        {
            this.gameObject.collider.enabled = false;
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + PenguinReStaySpeed * Time.deltaTime, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
            if (!IsInvoking("PenguinNoStay"))
                Invoke("PenguinNoStay", 0.3f);
        }
        else {
            this.gameObject.collider.enabled = true;
            this.gameObject.renderer.enabled = true;
            if (!IsInvoking("PenguinCounter"))
                Invoke("PenguinCounter", 3);
        }
	}
}
