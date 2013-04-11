using UnityEngine;
using System.Collections;

public class ReGuiAppear : MonoBehaviour {
    public GameObject ReGui_Value;
    public float ReWidth, ReHeight;
    public Texture[] TextureResoure_Time;    //貼圖素材
    public Vector2 TexturePosition_Time;     //貼圖位置
    public Texture[] TextureResoure_Score;    //貼圖素材
    public Vector2 TexturePosition_Score;     //貼圖位置
    public GUIStyle TextureStyle;       //貼圖style

    public Vector2 scale_Time = new Vector2(1, 1);
    public Vector2 scale_Score = new Vector2(1, 1);
    public Vector2 pivotPoint;

    private string numberToString_Time;       //數值轉字串
    private string numberToString_Score;       //數值轉字串
    private Vector2 textureSize;        //貼圖尺寸

	// Use this for initialization
	void Start () {
        
        this.textureSize = new Vector2(this.TextureResoure_Time[0].width, this.TextureResoure_Time[0].height);
        ReWidth = Screen.width / 1280.0f;
        ReHeight = Screen.height / 800.0f;
        this.numberToString_Time = ReGui_Value.GetComponent<ReGui>().TimeCounter.ToString("00");

        this.numberToString_Score = ReGui_Value.GetComponent<ReGui>().ReScore.ToString();
	}
    void Update()
    {
        ReWidth = Screen.width / 1280.0f;
        ReHeight = Screen.height / 800.0f;
        ReGui_Value.GetComponent<ReGui>().TimeCheck = true;
        this.numberToString_Time = ReGui_Value.GetComponent<ReGui>().TimeCounter.ToString("00");
    //    print(this.numberToString_Time);
        this.numberToString_Score = ReGui_Value.GetComponent<ReGui>().ReScore.ToString();
        
    }

    void OnGUI()
    {
      
        GUIUtility.ScaleAroundPivot(this.scale_Score, this.pivotPoint);

        for (int j = 0; j < this.numberToString_Score.Length; j++)
        {
            GUI.Box(new Rect((this.TexturePosition_Score.x + (this.textureSize.x) * j) * ReWidth,
                        this.TexturePosition_Score.y * ReHeight,
                        this.textureSize.x * ReWidth,
                        this.textureSize.y * ReHeight),
                    this.TextureResoure_Score[int.Parse(this.numberToString_Score[j].ToString())],
                    this.TextureStyle);
        }
  

        
        GUIUtility.ScaleAroundPivot(this.scale_Time, this.pivotPoint);

        for (int i = 0; i < this.numberToString_Time.Length; i++)
        {
            GUI.Box(new Rect((this.TexturePosition_Time.x + (this.textureSize.x) * i) * ReWidth,
                        this.TexturePosition_Time.y * ReHeight,
                        this.textureSize.x * ReWidth,
                        this.textureSize.y * ReHeight),
                    this.TextureResoure_Time[int.Parse(this.numberToString_Time[i].ToString())],
                    this.TextureStyle);
            
        }

        
    }
}
