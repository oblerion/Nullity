using nullity;
public class SceneTitle : Scene
{
    Text3D title;
    public SceneTitle() : base("title")
    {
        title = new Text3D("text_title","helloword",25,"Arial",Color.white);
        title.SetPosition(MainCamera.PositionX,MainCamera.PositionY,MainCamera.PositionZ+23);
        title.SetParent(this);
    }
    // call one time when SceneManager.SetScene("title") is call
    public override void Init()
    {

    }

    // call every frame
    public override void Update()
    {

    }
}
