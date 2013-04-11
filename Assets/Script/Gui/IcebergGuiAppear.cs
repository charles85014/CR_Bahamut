using UnityEngine;
using System.Collections;

public class IcebergGuiAppear : MonoBehaviour {
    public GameObject IceGui_Value;
    public float IceWidth, IceHeight;

    public Texture[] TextureResoure_Time;    //貼圖素材
    public Vector2 TexturePosition_Time;     //貼圖位置

    public Texture[] TextureResoure_Score;    //貼圖素材
    public Vector2 TexturePosition_Score;     //貼圖位置

 
    public Vector2 TexturePosition_Life;     //貼圖位置

    public GUIStyle TextureStyle;       //貼圖style

    public Vector2 scale_Time = new Vector2(1, 1);
    public Vector2 scale_Score = new Vector2(1, 1);
    public Vector2 scale_Life = new Vector2(1, 1);
    public Vector2 pivotPoint;

    private string numberToString_Time;       //數值轉字串
    private string numberToString_Score;       //數值轉字串
    private string numberToString_Life;       //數值轉字串
    private Vector2 textureSize;        //貼圖尺寸
	// Use this for initialization
	void Start () {
        this.textureSize = new Vector2(this.TextureResoure_Time[0].width, this.TextureResoure_Time[0].height);
        IceWidth = Screen.width / 1280.0f;
        IceHeight = Screen.height / 800.0f;
        this.numberToString_Time = IceGui_Value.GetComponent<IcebergGui>().I_TimeCounter.ToString("0000");

        this.numberToString_Score = IceGui_Value.GetComponent<IcebergGui>().IceScore.ToString();

        this.numberToString_Life = IceGui_Value.GetComponent<IcebergGui>().PenguinCounter.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        IceWidth = Screen.width / 1280.0f;
        IceHeight = Screen.height / 800.0f;
        IceGui_Value.GetComponent<IcebergGui>().TimeCheck_ice = true;
        this.numberToString_Time = IceGui_Value.GetComponent<IcebergGui>().I_TimeCounter.ToString("0000");

        this.numberToString_Score = IceGui_Value.GetComponent<IcebergGui>().IceScore.ToString();
        this.numberToString_Life = IceGui_Value.GetComponent<IcebergGui>().PenguinCounter.ToString();
	}

    void OnGUI()
    {

        GUIUtility.ScaleAroundPivot(this.scale_Score, this.pivotPoint);

        for (int j = 0; j < this.numberToString_Score.Length; j++)
        {
            GUI.Box(new Rect((this.TexturePosition_Score.x + (this.textureSize.x) * j) * IceWidth,
                        this.TexturePosition_Score.y * IceHeight,
                        this.textureSize.x * IceWidth,
                        this.textureSize.y * IceHeight),
                    this.TextureResoure_Score[int.Parse(this.numberToString_Score[j].ToString())],
                    this.TextureStyle);
        }



        GUIUtility.ScaleAroundPivot(this.scale_Time, this.pivotPoint);

        for (int i = 0; i < this.numberToString_Time.Length; i++)
        {
            GUI.Box(new Rect((this.TexturePosition_Time.x + (this.textureSize.x) * i) * IceWidth,
                        this.TexturePosition_Time.y * IceHeight,
                        this.textureSize.x * IceWidth,
                        this.textureSize.y * IceHeight),
                    this.TextureResoure_Time[int.Parse(this.numberToString_Time[i].ToString())],
                    this.TextureStyle);

        }

        GUIUtility.ScaleAroundPivot(this.scale_Life, this.pivotPoint);

        for (int k = 0; k < this.numberToString_Life.Length; k++)
        {
            GUI.Box(new Rect((this.TexturePosition_Life.x + (this.textureSize.x) * k) * IceWidth,
                        this.TexturePosition_Life.y * IceHeight,
                        this.textureSize.x * IceWidth,
                        this.textureSize.y * IceHeight),
                    this.TextureResoure_Time[int.Parse(this.numberToString_Life[k].ToString())],
                    this.TextureStyle);

        }


    }
}
