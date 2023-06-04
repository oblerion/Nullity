using System;
using System.Collections.Generic;
//using UnityEngine;
namespace nullity
{
    public class SceneManager : UnityEngine.MonoBehaviour
    {
        private float _timer;
        public string InitScene;
        private string _curant_state;
 
        private Dictionary<string,Scene> _list_scene;


        public void Start()
        {
            _timer=2;
            _list_scene = new Dictionary<string, Scene>()
            {
                ["title"] = new SceneTitle()
                // ["register"] = new SceneRegister(),
                // ["shooseship"] = new SceneShooseShip(),
                // ["game"] = new SceneGame(),
                // ["gameover"] = new SceneGameover()
            };
            if(InitScene!="") 
                _curant_state = InitScene;
            else 
                _curant_state="title";
            _list_scene[_curant_state].SetActive(true);
            _list_scene[_curant_state].Init();
            ServiceLocator.Register<SceneManager>(this);
        }
    
        public Scene GetCurantState()
        {
            return _list_scene[_curant_state];
        }
        public Scene GetScene(string name)
        {
            if(_list_scene.ContainsKey(name)) 
                return _list_scene[name];
            Debug.Warning("can't get scene "+name);
            return default(Scene);
        }

        public void SetScene(string name)
        {
            if(_list_scene.ContainsKey(name)) 
            {
                Scene scene = _list_scene[name];
                _list_scene[_curant_state].SetActive(false);
                _curant_state = name;
                scene.SetActive(true);
                scene.Init();
                _timer=0.01f;
            }
        }
        public void Update()
        {
            if(_timer<0)
            {
                _list_scene[_curant_state].Update();
            }
            else _timer -= Timer.getDelta();
        }
    }
}