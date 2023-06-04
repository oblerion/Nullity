namespace nullity
{
    public class Sprite3D : GameObject
    {
        private UnityEngine.SpriteRenderer _spriterenderer;
        private UnityEngine.Sprite _Sprite
		{
			set=>_spriterenderer.sprite=value;
		}  
        public UnityEngine.Sprite Sprite
        {
            get=>_spriterenderer.sprite;
        }
		public nullity.Color Color		
		{
			set=>_spriterenderer.color=value.ToUnity();
			get=>new nullity.Color(_spriterenderer.color);
		} 
        public float Width{get=>Sprite.bounds.size.x;}
		public float Height{get=>Sprite.bounds.size.y;}
		public bool FlipX{set=>_spriterenderer.flipX=value;}
		public bool FlipY{set=>_spriterenderer.flipY=value;}

        public Sprite3D(string name):base(name)
        {
            _spriterenderer = _gameobject.AddComponent<UnityEngine.SpriteRenderer>();
            _Sprite = ServiceLocator.Get<AssetManager>().GetSprite(name);
            Name=name;
        }

    }
}