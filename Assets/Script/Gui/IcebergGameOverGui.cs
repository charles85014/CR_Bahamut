using UnityEngine;
using System.Collections;

public class IcebergGameOverGui : MonoBehaviour {
    public AudioSource NormalButton;
   
    public IcebergGui IcebergGuiScore;
    public StageData stagedata;
    public GameObject endGuiPlane;
    public int PenguinDefeatCount;
    public GameObject IceGuiAppearObj;

   

    public float IceWidth, IceHeight;

    public float[] NextB = new float[6];//六個分別是位置的寬分子、分母，高分子、分母，圖片寬高常數
    public float[] BackTitleB = new float[6];
    public GUIStyle  nextbs, backts;

    public Texture[] TextureResoure_Your;    //貼圖素材
    public Vector2 TexturePosition_YourS;     //貼圖位置
    public Vector2 TexturePosition_YourT;     //貼圖位置

    public Texture[] TextureResoure_High;    //貼圖素材
    public Vector2 TexturePosition_HighS;     //貼圖位置
    public Vector2 TexturePosition_HighT;     //貼圖位置

    public GUIStyle TextureStyle;       //貼圖style

    private string numberToString_YourS;       //數值轉字串
    private string numberToString_YourT;       //數值轉字串

    private string numberToString_HighS;       //數值轉字串
    private string numberToString_HighT;       //數值轉字串
    private Vector2 textureSize;        //貼圖尺寸


    public Vector2 scale_Time = new Vector2(1, 1);
    public Vector2 pivotPoint;

	// Use this for initialization
	void Start () {
       
       
        this.textureSize = new Vector2(this.TextureResoure_High[0].width, this.TextureResoure_High[0].height);
        IceWidth = Screen.width / 1280.0f;
        IceHeight = Screen.height / 800.0f;

        this.numberToString_YourS = IcebergGuiScore.IceScore.ToString();
        this.numberToString_YourT = IcebergGuiScore.I_TimeCounter.ToString("0000");
        this.numberToString_HighS = ScoreRecord.Ice_Score[stagedata.StageCount - 1].ToString();
        this.numberToString_HighT = ScoreRecord.Ice_Time[stagedata.StageCount - 1].ToString("0000");
	}
    void OnGUI()
    {
        if (PenguinDefeatCount <= -2 )
        {
            
            Time.timeScale = 0;
            endGuiPlane.gameObject.SetActive(true);
           

            


            ///////////////////////////////////////////////////////////////////

            if (GUI.Button(new Rect(Screen.width * NextB[0] / NextB[1], Screen.height * NextB[2] / NextB[3], Screen.height * NextB[4],
                 Screen.height * NextB[5]), "", nextbs))
            {
                NormalButton.Play();
                Application.LoadLevel("Iceberg01");
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

                GUI.Box(new Rect((this.TexturePosition_YourS.x + (this.textureSize.x) * j) * IceWidth,
                            this.TexturePosition_YourS.y * IceHeight,
                            this.textureSize.x * IceWidth,
                            this.textureSize.y * IceHeight),
                        this.TextureResoure_Your[int.Parse(this.numberToString_YourS[j].ToString())],
                        this.TextureStyle);
                print(this.textureSize.x * IceWidth);
                print(this.textureSize.y * IceHeight);

            }

            for (int i = 0; i < this.numberToString_YourT.Length; i++)
            {

                GUI.Box(new Rect((this.TexturePosition_YourT.x + (this.textureSize.x) * i) * IceWidth,
                            this.TexturePosition_YourT.y * IceHeight,
                            this.textureSize.x * IceWidth,
                            this.textureSize.y * IceHeight),
                        this.TextureResoure_Your[int.Parse(this.numberToString_YourT[i].ToString())],
                        this.TextureStyle);
                print(this.textureSize.x * IceWidth);
                print(this.textureSize.y * IceHeight);

            }

            for (int k = 0; k < this.numberToString_HighS.Length; k++)
            {

                GUI.Box(new Rect((this.TexturePosition_HighS.x + (this.textureSize.x) * k) * IceWidth,
                            this.TexturePosition_HighS.y * IceHeight,
                            this.textureSize.x * IceWidth,
                            this.textureSize.y * IceHeight),
                        this.TextureResoure_High[int.Parse(this.numberToString_HighS[k].ToString())],
                        this.TextureStyle);
                print(this.textureSize.x * IceWidth);
                print(this.textureSize.y * IceHeight);

            }

            for (int u = 0; u < this.numberToString_HighT.Length; u++)
            {

                GUI.Box(new Rect((this.TexturePosition_HighT.x + (this.textureSize.x) * u) * IceWidth,
                            this.TexturePosition_HighT.y * IceHeight,
                            this.textureSize.x * IceWidth,
                            this.textureSize.y * IceHeight),
                        this.TextureResoure_High[int.Parse(this.numberToString_HighT[u].ToString())],
                        this.TextureStyle);
             

            }
           
        }
        

    }
	// Update is called once per frame
	void Update () {
        IceWidth = Screen.width / 1280.0f;
        IceHeight = Screen.height / 800.0f;

        this.numberToString_YourS = IcebergGuiScore.IceScore.ToString();
        this.numberToString_YourT = IcebergGuiScore.I_TimeCounter.ToString("0000");
        this.numberToString_HighS = ScoreRecord.Ice_Score[stagedata.StageCount - 1].ToString();
        this.numberToString_HighT = ScoreRecord.Ice_Time[stagedata.StageCount - 1].ToString("0000");
        if (PenguinDefeatCount <= -2)
            IceGuiAppearObj.SetActive(false);

        if (ScoreRecord.Ice_Score[stagedata.StageCount - 1] < IcebergGuiScore.IceScore)
            ScoreRecord.Ice_Score[stagedata.StageCount - 1] = IcebergGuiScore.IceScore;

        if (ScoreRecord.Ice_Time[stagedata.StageCount - 1] < IcebergGuiScore.I_TimeCounter)
            ScoreRecord.Ice_Time[stagedata.StageCount - 1] = (int)IcebergGuiScore.I_TimeCounter;
	}
}
