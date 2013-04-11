using UnityEngine;
using System.Collections;

public class IceRoadMove : MonoBehaviour {
    public IcebergGui IceGui;
   // public Material IceRoad;
    float IceRoadTOS_X = 0;
	// Use this for initialization
	void Start () {
        this.renderer.material.mainTextureOffset.Set(0, 0);
      
	}
	
	// Update is called once per frame
	void Update () {
        IceRoadTOS_X += 0.2f*Time.deltaTime * IceGui.IceRoadRate;
        this.renderer.material.mainTextureOffset = new Vector2(IceRoadTOS_X,0);
        if (IceRoadTOS_X >= 1) IceRoadTOS_X = 0;
       
	}
}
