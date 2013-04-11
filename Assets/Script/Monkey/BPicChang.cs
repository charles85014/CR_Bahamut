using UnityEngine;
using System.Collections;

public class BPicChang : MonoBehaviour {
    public Texture[] ChangPic;
    private int currentIndexs = 0;

    public MonkeyGui MChangPicSpeed;
    // Use this for initialization
    void Start()
    {
        this.gameObject.GetComponent<BPicChang>().enabled = false;
        MChangPicSpeed = GameObject.Find("MonkeyGui").GetComponent<MonkeyGui>();
    }
    
    void Create()
    {
        renderer.material.mainTexture = ChangPic[currentIndexs];
        currentIndexs++;
        if (currentIndexs >= ChangPic.Length)
            currentIndexs = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (!IsInvoking("Create"))
            Invoke("Create", MChangPicSpeed.MonkeyChangPic);
    }
}
