using UnityEngine;
using System.Collections;

public class MEnum : MonoBehaviour
{
    //��r���A
    public enum TextType { INT, FLOAT, STRING };
    //�U��Ease���覡
    public enum EaseType
    {
        easeInQuad,
        easeOutQuad,
        easeInOutQuad,
        easeInCubic,
        easeOutCubic,
        easeInOutCubic,
        easeInQuart,
        easeOutQuart,
        easeInOutQuart,
        easeInQuint,
        easeOutQuint,
        easeInOutQuint,
        easeInSine,
        easeOutSine,
        easeInOutSine,
        easeInExpo,
        easeOutExpo,
        easeInOutExpo,
        easeInCirc,
        easeOutCirc,
        easeInOutCirc,
        linear,
        spring,
        /* GFX47 MOD START */
        //bounce,
        easeInBounce,
        easeOutBounce,
        easeInOutBounce,
        /* GFX47 MOD END */
        easeInBack,
        easeOutBack,
        easeInOutBack,
        /* GFX47 MOD START */
        //elastic,
        easeInElastic,
        easeOutElastic,
        easeInOutElastic,
        /* GFX47 MOD END */
        punch
    }
    //Itween���`���覡
    public enum loopType { none, pingPong, loop }


    // �S���ܼ� structure
    public struct EffectStruct
    {
        //��m�P�j�p
        public Rect rect;

        //��r�j�p
        public int fontSize;

        //��r�C��
        public Color color;

        //�����`�� - ���ȶV�e��
        public int depth;

        //����ɶ�
        public float time;

        //����ɶ�
        public float delay;

        //�`���覡
        public loopType looptype;

        //Ease�覡
        public EaseType easeType;
    }



    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {


    }
}
