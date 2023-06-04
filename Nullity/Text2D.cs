using UnityEngine;
using UnityEngine.UI;
namespace nullity
{
    public class Text2D : nullity.GameObject
    {
        private Text _txt;
        public string Text{get=>_txt.text; set=>_txt.text=value;}
        public int fontSize{set=>_txt.fontSize=value;}
        public Color Color{set=>_txt.color=value.ToUnity();}
        public Text2D(UnityEngine.GameObject obj):base(obj)
        {
            _txt =  obj.GetComponent<Text>();
        }
        public Text2D(string name,int x,int y,string text,int size=12):base(name)
        {
            RectTransform trans = _gameobject.AddComponent<RectTransform>();
            trans.anchoredPosition = new UnityEngine.Vector2(x,y);
            _txt = _gameobject.AddComponent<Text>();
            _txt.text = text;
            _txt.horizontalOverflow = HorizontalWrapMode.Overflow;
            Font font = _txt.GetComponent<Font>();
            string sfont = Font.GetOSInstalledFontNames()[0];
            _txt.font = Font.CreateDynamicFontFromOSFont(sfont, size);
            _txt.color = Color.white.ToUnity();
            //Resources.GetBuiltinResource<Font>("Arial.ttf")
        }
        public Text2D(string name,int x,int y,string text,string font,int size=12):base(name)
        {
            RectTransform trans = _gameobject.AddComponent<RectTransform>();
            trans.anchoredPosition = new UnityEngine.Vector2(x,y);
            _txt = _gameobject.AddComponent<Text>();
            _txt.text = text;
            _txt.horizontalOverflow = HorizontalWrapMode.Overflow;
            string sfont = Font.GetOSInstalledFontNames()[0];
            _txt.font =Resources.Load<Font>("Font/"+font);
            //_txt.font.material = 
            Resources.Load<Material>("Materials/text");
            fontSize=size;
            _txt.color = Color.white.ToUnity();
//Font.CreateDynamicFontFromOSFont(sfont, size);
            //Resources.GetBuiltinResource<Font>("Arial.ttf")
        }
    }
}
