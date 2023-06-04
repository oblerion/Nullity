using UnityEngine;
namespace nullity
{
    public class Text3D : GameObject
    {
        protected TextMesh _textmesh;
        private MeshRenderer _meshrenderer;
        public string Text{set=>_textmesh.text=value; get=>_textmesh.text;}
		public Color Color{set=>_textmesh.color=value.ToUnity();}
        public Text3D(string name,string text,int size,string font,Color color):base(name)
        {
	        _textmesh = _gameobject.AddComponent<TextMesh>();
			_meshrenderer = _gameobject.GetComponent<MeshRenderer>();
			
			_textmesh.anchor = TextAnchor.UpperCenter;
			_textmesh.text = text;
			_textmesh.fontSize = size;
		
			SetFont(font);
			_textmesh.color = color.ToUnity();
        }
	    public void SetFont(string font)
		{
			Font myfont = ServiceLocator.Get<AssetManager>().GetFont(font);
			if(myfont!=null)
			{
				_meshrenderer.material = myfont.material;
				_textmesh.font = myfont;
			}
		}
    }
}