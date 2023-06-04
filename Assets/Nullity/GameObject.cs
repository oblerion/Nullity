using UnityEngine;
namespace nullity
{
//base object
    public class GameObject
    {
        protected UnityEngine.GameObject _gameobject;
        public string Name
        {
            get=>_gameobject.name;
            set=>_gameobject.name=value;
        }
        // public nullity.Vector3 Position
        // {
        //     get=> new nullity.Vector3(_gameobject.transform.position);
        // }
        public float PositionX {get=>_gameobject.transform.position.x;}
        public float PositionY {get=>_gameobject.transform.position.y;}
        public float PositionZ {get=>_gameobject.transform.position.z;}


        public nullity.Vector3 Rotation
        {
            get=> new nullity.Vector3(_gameobject.transform.rotation.eulerAngles);
        }
        public nullity.Vector3 Scale
        {
			set=> _gameobject.transform.localScale = value.ToUnity;
		}
        protected Transform _Transform{get=>_gameobject.transform;}
 
        public GameObject()
        { 
            _gameobject = new UnityEngine.GameObject();
            _gameobject.name = "void";
        }

        public GameObject(UnityEngine.MonoBehaviour mono)
        {
            _gameobject = mono.gameObject;
        }
        public GameObject(UnityEngine.GameObject go)
        {
            if(go!=null) _gameobject = go;
		}
        public GameObject(UnityEngine.Sprite spr)
        {
// to do
        }
        public static GameObject Find(string name)
        {
            UnityEngine.GameObject go = UnityEngine.GameObject.Find(name);
            if(go!=null) return new GameObject(go);
            return default(GameObject);
        }
        public void Copy(nullity.GameObject go)
        {
            _gameobject = go._gameobject;
        }
        public GameObject(nullity.GameObject obj)
        {
            _gameobject = UnityEngine.GameObject.Instantiate(obj._gameobject);
            _gameobject.name = obj.Name;
        }
        public GameObject(string name)
        {
            _gameobject = new UnityEngine.GameObject();
            _gameobject.name = name;   
        }
        public void SetRotation(float x,float y,float z)
        {
			_gameobject.transform.rotation = Quaternion.Euler(x,y,z);
		}
	
        public void Rotate(float x,float y,float z)
        {
            _gameobject.transform.rotation *= Quaternion.Euler(x,y,z);
        }
        public void SetPosition(float x,float y,float z)
        {
			_gameobject.transform.position = new UnityEngine.Vector3(x,y,z);
		}
	
		public void Translate(float x,float y,float z)
		{
			_gameobject.transform.position += new UnityEngine.Vector3(x,y,z);
		}
	
        public void SetParent(MonoBehaviour mb)
        {   
            _gameobject.transform.SetParent(mb.transform,worldPositionStays: false);
        }
        public void SetParent(nullity.GameObject obj)
        {
            _gameobject.transform.SetParent(obj._gameobject.transform,worldPositionStays: false);
        }
        public void SetChild(nullity.GameObject obj)
        {
            obj.SetParent(this);
        }
        
        public nullity.GameObject GetChild(string name)
        {
            UnityEngine.Transform trans = _gameobject.transform.Find(name);
            if(trans==null)return default(nullity.GameObject);
            return new nullity.GameObject(trans.gameObject);
        }
        public void SetActive(bool state)
        {
            _gameobject.SetActive(state);
        }
        public void Destroy()
		{
			if(_gameobject!=null) 
            {
                UnityEngine.GameObject.Destroy(_gameobject);
                _gameobject=null;
            }
		}
    }
}