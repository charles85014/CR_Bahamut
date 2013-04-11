using UnityEngine;
using System.Collections;

public class PenguinCollision02 : MonoBehaviour {
    public IcebergGui P_IceGui;
    public IcebergGameOverGui P_IceGameOverGui;
    public GameObject PenguinStayPlace;
    public bool PCollisionB02 = true;
    public float PenguinStayPosX02;
    public int PenguinReStaySpeed;
    public bool PenguinNoStayCount = true;
    // Use this for initialization
    void Start()
    {

        PenguinStayPosX02 = -2.5f;

    }
   /* void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Snowman(Clone)" || other.gameObject.name == "IceHoleBig(Clone)" || other.gameObject.name == "IceHoleS(Clone)")
        {
            this.gameObject.transform.position = new Vector3(PenguinStayPlace.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
            if (P_IceGui.PenguinCounter > 0)
                P_IceGui.PenguinCounter--;
            P_IceGameOverGui.PenguinDefeatCount--;
            print("BooM02");
        }
   
    }*/
    void PenguinNoStay()
    {
        if (PenguinNoStayCount == true)
        {
            this.gameObject.renderer.enabled = true;
            PenguinNoStayCount = false;
        }
        else if (PenguinNoStayCount == false)
        {
            this.gameObject.renderer.enabled = false;
            PenguinNoStayCount = true;
        }

    }

    void PenguinCounter()
    {

        P_IceGui.PenguinCount02++;

    }
    void PenguinCollisionB02() {
        this.gameObject.collider.enabled = true;
        this.gameObject.renderer.enabled = true;
        PCollisionB02 = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.x < PenguinStayPosX02 - 0.05f)
        {
            PCollisionB02 = false;
            this.gameObject.collider.enabled = false;
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + PenguinReStaySpeed * Time.deltaTime, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
            if (!IsInvoking("PenguinNoStay"))
                Invoke("PenguinNoStay", 0.3f);
        }
        else
        {
            if (PCollisionB02 == false)
            {
                if (!IsInvoking("PenguinCollisionB02"))
                {
                    Invoke("PenguinCollisionB02", 0.1f);
                }
            }
            if (!IsInvoking("PenguinCounter"))
                Invoke("PenguinCounter", 3);
        }
    }
}
