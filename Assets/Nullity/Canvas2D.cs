namespace nullity
{
    public class Canvas2D:GameObject
    {
        public Canvas2D(UnityEngine.MonoBehaviour mono):base("Canvas")
        {
           
            GameObject state = new GameObject(mono);
            GameObject obj_canvas = state.GetChild("Canvas");
            if( obj_canvas == null)
            {
                SetParent(mono);
                UnityEngine.Canvas canvas = _gameobject.AddComponent<UnityEngine.Canvas>();
                canvas.renderMode = UnityEngine.RenderMode.ScreenSpaceCamera;
                canvas.worldCamera = MainCamera.Camera;
               
            }
            else
            {
                Destroy();
                Copy(obj_canvas);
                // UnityEngine.Canvas canvas = _gameobject.GetComponent<UnityEngine.Canvas>();
                // canvas.renderMode = UnityEngine.RenderMode.ScreenSpaceCamera;
                // canvas.worldCamera = MainCamera.Camera;
              
            }
        }
        public Text2D Text(string name,int x,int y,string text,int size=12)
        {
            Text2D t2 = new Text2D(name,x,y,text,size);
            t2.SetParent(this);
            return t2;
        }
        public Text2D Text(string name)
        {
            UnityEngine.GameObject t = UnityEngine.GameObject.Find(name);
            return new Text2D(t);
        }
        public Text2D Text(string name,int x,int y,string text,string font,int size=12)
        {
            Text2D t2 = new Text2D(name,x,y,text,font,size);
            t2.SetParent(this);
            return t2;
        }
        public TextInput2D TextInput(string name,int x,int y,int size=12)
        {
            TextInput2D ti2 = new TextInput2D(name,x,y,size);
            ti2.SetParent(this);
            return ti2;
        }
        public TextInput2D TextInput(string name,int x,int y,string font,int size=12)
        {
            TextInput2D ti2 = new TextInput2D(name,x,y,font,size);
            ti2.SetParent(this);
            return ti2;
        }
        public Sprite2D Sprite(string name,int x,int y,string sprite)
        {
            Sprite2D spr = new Sprite2D(name,x,y,sprite);
            spr.SetParent(this);
            return spr;
        }
    }
   
}