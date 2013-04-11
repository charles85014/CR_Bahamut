using UnityEngine;
using System.Collections;

public class MonkeyGameOverGui : MonoBehaviour {
    public AudioSource NormalButton;
    public MonkeyGui MonGuiScore;
    public StageData stagedata;
    public GameObject endGuiPlane;
    public GameObject MonGuiAppearObj;

    public float MonWidth, MonHeight;
  
    public float[] NextB = new float[6];//六個分別是位置的寬分子、分母，高分子、分母，圖片寬高常數
    public float[] BackTitleB = new float[6];
    public GUIStyle  nextbs, backts;

    public Texture[] TextureResoure_Your;    //貼圖素材
    public Vector2 TexturePosition_YourS;     //貼圖位置
    public Vector2 TexturePosition_YourB;     //貼圖位置
    public Vector2 TexturePosition_YourD;     //貼圖位置

    public Texture[] TextureResoure_High;    //貼圖素材
    public Vector2 TexturePosition_HighS;     //貼圖位置
    public Vector2 TexturePosition_HighB;     //貼圖位置
    public Vector2 TexturePosition_HighD;     //貼圖位置

    public GUIStyle TextureStyle;       //貼圖style

    private string numberToString_YourS;       //數值轉字串
    private string numberToString_YourB;       //數值轉字串
    private string numberToString_YourD;       //數值轉字串

    private string numberToString_HighS;       //數值轉字串
    private string numberToString_HighB;       //數值轉字串
    private string numberToString_HighD;       //數值轉字串
    private Vector2 textureSize;        //貼圖尺寸


    public Vector2 scale_Time = new Vector2(1, 1);
    public Vector2 pivotPoint;
	// Use this for initialization
	void Start () {
        this.textureSize = new Vector2(this.TextureResoure_High[0].width, this.TextureResoure_High[0].height);
        MonWidth = Screen.width / 1280.0f;
        MonHeight = Screen.height / 800.0f;


        this.numberToString_YourS = MonGuiScore.M_Score.ToString();
        this.numberToString_YourB = MonGuiScore.Banana_Counter.ToString();
        this.numberToString_YourD = MonGuiScore.Durian_Counter.ToString();


        this.numberToString_HighS = ScoreRecord.Mo_Score[stagedata.StageCount - 1].ToString();
        this.numberToString_HighB = ScoreRecord.Mo_BananaC[stagedata.StageCount - 1].ToString();
        this.numberToString_HighD = ScoreRecord.Mo_DurianC[stagedata.StageCount - 1].ToString();

	
	}
    void OnGUI()
    {
        if (MonGuiScore.M_TimeCounter <= 0)
        {

            Time.timeScale = 0.00000001f;
            endGuiPlane.gameObject.SetActive(true);
            if (ScoreRecord.Mo_Score[stagedata.StageCount - 1] < MonGuiScore.M_Score)
                ScoreRecord.Mo_Score[stagedata.StageCount - 1] = MonGuiScore.M_Score;

            if (ScoreRecord.Mo_BananaC[stagedata.StageCount - 1] < MonGuiScore.Banana_Counter)
                ScoreRecord.Mo_BananaC[stagedata.StageCount - 1] = MonGuiScore.Banana_Counter;

            if (ScoreRecord.Mo_DurianC[stagedata.StageCount - 1] < MonGuiScore.Durian_Counter)
                ScoreRecord.Mo_DurianC[stagedata.StageCount - 1] = MonGuiScore.Durian_Counter;

            /////////////////////////////////////////////////////////////////

            

            if (GUI.Button(new Rect(Screen.width * NextB[0] / NextB[1], Screen.height * NextB[2] / NextB[3], Screen.height * NextB[4],
                 Screen.height * NextB[5]), "", nextbs))
            {
                NormalButton.Play();
                Application.LoadLevel("Monkey01");
            }

            if (GUI.Button(new Rect(Screen.width * BackTitleB[0] / BackTitleB[1], Screen.height * BackTitleB[2] / BackTitleB[3], Screen.height * BackTitleB[4],
                Screen.height * BackTitleB[5]), "", backts))
            {
                NormalButton.Play();
                Application.LoadLevel("Start");
            }

            GUIUtility.ScaleAroundPivot(this.scale_Time, this.pivotPoint);

            for (int j = 0; j < this.numberToString_YourS.Length; j++)
            {

                GUI.Box(new Rect((this.TexturePosition_YourS.x + (this.textureSize.x) * j) * MonWidth,
                            this.TexturePosition_YourS.y * MonHeight,
                            this.textureSize.x * MonWidth,
                            this.textureSize.y * MonHeight),
                        this.TextureResoure_Your[int.Parse(this.numberToString_YourS[j].ToString())],
                        this.TextureStyle);
                print(this.textureSize.x * MonWidth);
                print(this.textureSize.y * MonHeight);

            }

            for (int i = 0; i < this.numberToString_YourB.Length; i++)
            {

                GUI.Box(new Rect((this.TexturePosition_YourB.x + (this.textureSize.x) * i) * MonWidth,
                            this.TexturePosition_YourB.y * MonHeight,
                            this.textureSize.x * MonWidth,
                            this.textureSize.y * MonHeight),
                        this.TextureResoure_Your[int.Parse(this.numberToString_YourB[i].ToString())],
                        this.TextureStyle);
                print(this.textureSize.x * MonWidth);
                print(this.textureSize.y * MonHeight);

            }

            for (int k = 0; k < this.numberToString_YourD.Length; k++)
            {

                GUI.Box(new Rect((this.TexturePosition_YourD.x + (this.textureSize.x) * k) * MonWidth,
                            this.TexturePosition_YourD.y * MonHeight,
                            this.textureSize.x * MonWidth,
                            this.textureSize.y * MonHeight),
                        this.TextureResoure_Your[int.Parse(this.numberToString_YourD[k].ToString())],
                        this.TextureStyle);
                print(this.textureSize.x * MonWidth);
                print(this.textureSize.y * MonHeight);

            }

            for (int l = 0; l < this.numberToString_HighS.Length; l++)
            {

                GUI.Box(new Rect((this.TexturePosition_HighS.x + (this.textureSize.x) * l) * MonWidth,
                            this.TexturePosition_HighS.y * MonHeight,
                            this.textureSize.x * MonWidth,
                            this.textureSize.y * MonHeight),
                        this.TextureResoure_High[int.Parse(this.numberToString_HighS[l].ToString())],
                        this.TextureStyle);


            }

            for (int m = 0; m < this.numberToString_HighB.Length; m++)
            {

                GUI.Box(new Rect((this.TexturePosition_HighB.x + (this.textureSize.x) * m) * MonWidth,
                            this.TexturePosition_HighB.y * MonHeight,
                            this.textureSize.x * MonWidth,
                            this.textureSize.y * MonHeight),
                        this.TextureResoure_High[int.Parse(this.numberToString_HighB[m].ToString())],
                        this.TextureStyle);


            }

            for (int n = 0; n < this.numberToString_HighD.Length; n++)
            {

                GUI.Box(new Rect((this.TexturePosition_HighD.x + (this.textureSize.x) * n) * MonWidth,
                            this.TexturePosition_HighD.y * MonHeight,
                            this.textureSize.x * MonWidth,
                            this.textureSize.y * MonHeight),
                        this.TextureResoure_High[int.Parse(this.numberToString_HighD[n].ToString())],
                        this.TextureStyle);


            }


        }

    }
	// Update is called once per frame
	void Update () {
        MonWidth = Screen.width / 1280.0f;
        MonHeight = Screen.height / 800.0f;
        if (MonGuiScore.M_TimeCounter <= 0)
            MonGuiAppearObj.SetActive(false);

        this.numberToString_YourS = MonGuiScore.M_Score.ToString();
        this.numberToString_YourB = MonGuiScore.Banana_Counter.ToString();
        this.numberToString_YourD = MonGuiScore.Durian_Counter.ToString();


        this.numberToString_HighS = ScoreRecord.Mo_Score[stagedata.StageCount - 1].ToString();
        this.numberToString_HighB = ScoreRecord.Mo_BananaC[stagedata.StageCount - 1].ToString();
        this.numberToString_HighD = ScoreRecord.Mo_DurianC[stagedata.StageCount - 1].ToString();
	}
}
