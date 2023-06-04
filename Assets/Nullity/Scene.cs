
namespace nullity
{
    public abstract class Scene : GameObject
    {
        public Scene(string name) : base(name)
        {
            SetActive(false);
        }

        public abstract void Init();
        public abstract void Update();
    }
}