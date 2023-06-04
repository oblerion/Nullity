using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace nullity
{
    public class Sprite2D : GameObject
    {
        private Image _img;
        public Sprite2D(UnityEngine.Sprite sprite)
        {
// to do
        }
        public Sprite2D(string name,int x,int y,string sprite):base(name)
        {
     
            _img = _gameobject.AddComponent<Image>();
            _img.sprite = Resources.Load<UnityEngine.Sprite>(sprite);
            _img.preserveAspect = true;
            RectTransform trans = _gameobject.GetComponent<RectTransform>();
            trans.anchoredPosition = new UnityEngine.Vector2(x,y);
            // UnityEngine.Vector3 v3 = _img.sprite.bounds.size;
            // trans.width = v3.x;
            // trans.height = v3.y;
        }
    }
}