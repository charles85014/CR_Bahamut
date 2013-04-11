using UnityEngine;
using System.Collections;

public class ReGameOverGUI : MonoBehaviour {
    public AudioSource NormalButton;
    public ReGui ReGUIScore;
    public StageData stagedata;
    public GameObject endGuiplane;
    public GameObject ReGuiAppearObj;
  
 
    public float[] NextB = new float[6];
    public float[] BackTitleB = new float[6];
    public GUIStyle nextbs, backts;
    

    public Vector2 scale_Score = new Vector2(1, 1);
    public Vector2 pivotPoint;


    public Texture[] TextureResoure_Your;    //貼圖素材
    public Vector2 TexturePosition_Your;     //貼圖位置
    public Texture[] TextureResoure_High;    //貼圖素材
    public Vector2 TexturePosition_High;     //貼圖位置
    public GUIStyle TextureStyle;       //貼圖style

    private string numberToString_Your;       //數值轉字串
    private string numberToString_High;       //數值轉字串
    private Vector2 textureSize;        //貼圖尺寸
    public float ReWidth, ReHeight;
	// Use this for initialization
	void Start () {
        ReWidth = Screen.width / 1280.0f;
        ReHeight = Screen.height / 800.0f;
        this.numberToString_Your = ReGUIScore.ReScore.ToString();
        //    print(this.numberToString_Time);
        this.numberToString_High = ScoreRecord.Re_Score[stagedata.StageCount - 1].ToString();
        this.textureSize = new Vector2(this.TextureResoure_Your[0].width, this.TextureResoure_Your[0].height);
	}
    void OnGUI() {
        if (ReGUIScore.TimeCounter <= 0) {
            
            Time.timeScale = 0.00000001f;
            endGuiplane.gameObject.SetActive(true);
            
            if (ScoreRecord.Re_Score[stagedata.StageCount-1] < ReGUIScore.ReScore)
                ScoreRecord.Re_Score[stagedata.StageCount-1] = ReGUIScore.ReScore;

            if (GUI.Button(new Rect(Screen.width * NextB[0] / NextB[1], Screen.height * NextB[2] / NextB[3], Screen.height * NextB[4],
                 Screen.height * NextB[5]), "", nextbs))
            {
                if (stagedata.StageCount == 2)
                {
                    NormalButton.Play();
                    Application.LoadLevel("Start");
                }
                else
                {
                    NormalButton.Play();
                    Application.LoadLevel("R_0" + (stagedata.StageCount + 1));
                }
            }

            if (GUI.Button(new Rect(Screen.width * BackTitleB[0] / BackTitleB[1], Screen.height * BackTitleB[2] / BackTitleB[3], Screen.height * BackTitleB[4],
                Screen.height * BackTitleB[5]), "", backts))
            {
                NormalButton.Play();
                Application.LoadLevel("Start");
            }

            GUIUtility.ScaleAroundPivot(this.scale_Score, this.pivotPoint);

            for (int j = 0; j < this.numberToString_Your.Length; j++)
            {
            
                GUI.Box(new Rect((this.TexturePosition_Your.x + (this.textureSize.x) * j) * ReWidth,
                            this.TexturePosition_Your.y * ReHeight,
                            this.textureSize.x * ReWidth,
                            this.textureSize.y * ReHeight),
                        this.TextureResoure_Your[int.Parse(this.numberToString_Your[j].ToString())],
                        this.TextureStyle);
                print(this.textureSize.x * ReWidth);
                print(this.textureSize.y * ReHeight);

            }

            for (int i = 0; i < this.numberToString_High.Length; i++)
            {
                GUI.Box(new Rect((this.TexturePosition_High.x + (this.textureSize.x) * i) * ReWidth,
                            this.TexturePosition_High.y * ReHeight,
                            this.textureSize.x * ReWidth,
                            this.textureSize.y * ReHeight),
                        this.TextureResoure_High[int.Parse(this.numberToString_High[i].ToString())],
                        this.TextureStyle);

            }
     
        }
    
    }
	// Update is called once per frame
	void Update () {
        ReWidth = Screen.width / 1280.0f;
        ReHeight = Screen.height / 800.0f;
        this.numberToString_Your = ReGUIScore.ReScore.ToString();
        //    print(this.numberToString_Time);
        this.numberToString_High = ScoreRecord.Re_Score[stagedata.StageCount - 1].ToString();
        if (ReGUIScore.TimeCounter <= 0)
            ReGuiAppearObj.SetActive(false);
	}
}
