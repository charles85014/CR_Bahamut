using UnityEngine;
using System.Collections;

public class ScreenTest : MonoBehaviour {

public float wantedAspectRatio = 1.3333333f;

    static Camera cam;
	// Use this for initialization
    public void Awake () {

        cam = camera;

        if (!cam) {

            cam = Camera.main;

        }

        if (!cam) {

            Debug.LogError ("No camera available");

            return;

        }

        float currentAspectRatio = (float)Screen.width / Screen.height;

        // If the current aspect ratio is already approximately equal to the desired aspect ratio, don't do anything

        if ((int)(currentAspectRatio * 100) / 100.0f == (int)(wantedAspectRatio * 100) / 100.0f) {

            return;

        }

        // Pillarbox

        if (currentAspectRatio > wantedAspectRatio) {

            float inset = 1.0f - wantedAspectRatio/currentAspectRatio;

            cam.rect = new Rect(inset/2, 0.0f, 1.0f-inset, 1.0f);

        }

        // Letterbox

        else {

            float inset = 1.0f - currentAspectRatio/wantedAspectRatio;

            cam.rect = new Rect(0.0f, inset/2, 1.0f, 1.0f-inset);

        }

        // Make a new camera behind the normal camera which displays black; otherwise the unused space is undefined

        Camera backgroundCam = new GameObject("BackgroundCam", typeof(Camera)).camera;

        backgroundCam.depth = cam.depth-1;

        backgroundCam.backgroundColor = Color.black;

    }
    
     public static int screenHeight {

        get {

            return (int)(Screen.height * cam.rect.height);

        }

    }

    

    public static int screenWidth {

        get {

            return (int)(Screen.width * cam.rect.width);

        }

    }

    

    public static Vector3 mousePosition {

        get {

            Vector3 mousePos = Input.mousePosition;

            mousePos.y -= (int)(cam.rect.y * Screen.height);

            mousePos.x -= (int)(cam.rect.x * Screen.width);

            return mousePos;

        }

    }    

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}