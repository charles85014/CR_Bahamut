using UnityEngine;
using System.Collections;

public class ChangPicture : MonoBehaviour {
    
    
    public Texture[] ChangPic;
    private int currentIndexs = 0;

    public float[] changTimes;
	// Use this for initialization
	void Start () {
	
	}

    void Create()
    {
        renderer.material.mainTexture = ChangPic[currentIndexs];
        currentIndexs++;
        if (currentIndexs >= ChangPic.Length)
            currentIndexs = 0;
    }
	

	// Update is called once per frame
	void Update () {
            //renderer.material.mainTexture = ChangPic[0];
	    if(!IsInvoking("Create"))
            Invoke("Create", changTimes[currentIndexs]);


	}
}
