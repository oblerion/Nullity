I don't want to use unity in future, so you can rename,modify,share it.</br>

# run demo helloword
### 1) Create new 3d project
- Copy Nullity folder in Assets dir
- Copy SceneTitle.cs in Assets
- Create void gameobject and attach AssetManager.cs and SceneManager.cs.
### 2) On AssetManager (editor)
- add Arial font on list_font
### 3) run it

# Scene example
```csharp
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
```
# Install 
just copy Nullity folder in your project.

# Nullity
- lot of class can be userfull for make game without doc of unity.
- nullity use ServiceLocator.cs internaly 
- for 2D create Canvas2D and use it  
- to do wiki ...

# API
[full api](wiki)




