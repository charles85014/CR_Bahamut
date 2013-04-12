using UnityEngine;
using System.Collections;

public class MouseOver : MonoBehaviour {

    public Object DisplayObject;
    private Rect rect;

    public GameObject EffectObject;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        rect = (Rect)(DisplayObject.GetType().GetField("_rect").GetValue(DisplayObject));


        if (rect.Contains(new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y)))
            EffectObject.SetActive(true);
        else
            EffectObject.SetActive(false);

         if (rect.Contains(new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y)))
             if(Input.GetKeyDown(KeyCode.Mouse0))
                 print("lol");
	}
}
