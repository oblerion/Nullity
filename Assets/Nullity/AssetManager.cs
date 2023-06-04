using System.Collections.Generic;
namespace nullity
{
    
    public class AssetManager : UnityEngine.MonoBehaviour
    {
        public List<UnityEngine.Font> list_font;
        public List<UnityEngine.GameObject> list_model;
        public List<UnityEngine.Sprite> list_sprite;
    
        private Dictionary<string,UnityEngine.Font> _list_font;
        private Dictionary<string,Model> _list_model;
        private Dictionary<string,UnityEngine.Sprite> _list_sprite;
 
        public void Awake()
        {
            _list_font = new Dictionary<string,UnityEngine.Font>();
            _list_model = new Dictionary<string,Model>();
            _list_sprite = new Dictionary<string,UnityEngine.Sprite>();
            foreach (UnityEngine.Font item in list_font)
            {
                if(item!=null)_list_font.Add(item.name,item);
            }
            foreach (UnityEngine.GameObject item in list_model)
            {
                if(item!=null)_list_model.Add(item.name,new Model(item));
            }
            foreach (UnityEngine.Sprite item in list_sprite)
            {
                if(item!=null) _list_sprite.Add(item.name,item);
            }
      
            ServiceLocator.Register<AssetManager>(this);
        }
        public UnityEngine.Font GetFont(string name)
        {
            if(_list_font.ContainsKey(name))
            {
                return _list_font[name];
            }
            Debug.Warning("can't found font "+name);
            return default(UnityEngine.Font);
        }
        public Model GetModel(string name)
        {
            if(_list_model.ContainsKey(name))
            {
                return _list_model[name];
            }
            Debug.Warning("can't found model "+name);
            return default(Model);
        }
        public UnityEngine.Sprite GetSprite(string name)
        {
            if(_list_sprite.ContainsKey(name))
            {
                return _list_sprite[name];
            }
            Debug.Warning("can't found sprite "+name);
            return default(UnityEngine.Sprite);
        }
    
    }
}