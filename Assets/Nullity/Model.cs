using UnityEngine;
namespace nullity
{
// problem de creation 
    public class Model : nullity.GameObject
	{
		private Mesh _Mesh{set=>_gameobject.GetComponent<MeshFilter>().mesh=value;}
		private Material _Material{set=>_gameobject.GetComponent<MeshRenderer>().material=value;}    
		public Mesh Mesh{get=>_gameobject.GetComponent<MeshFilter>().sharedMesh;}
		public Material Material{get=>_gameobject.GetComponent<MeshRenderer>().sharedMaterial;}
		private float _sizeX;
		private float _sizeY;
		private float _sizeZ;
		public float SizeX{get=>_sizeX;}
		public float SizeY{get=>_sizeY;}
		public float SizeZ{get=>_sizeZ;}
	   	public Model(string name):base(name)
		{
			Model mod = ServiceLocator.Get<AssetManager>().GetModel(name);
			_gameobject.AddComponent<MeshFilter>();
			_gameobject.AddComponent<MeshRenderer>();
			SetModel(mod);
		}
		public Model(Model pobj) : base(pobj.Name) 
		{
			_gameobject.AddComponent<MeshFilter>();
			_gameobject.AddComponent<MeshRenderer>();
			SetModel(pobj);
		}
		public Model(UnityEngine.GameObject prefab) : base(prefab)
		{
			//_gameobject = UnityEngine.GameObject.Instantiate(prefab);
			Name = prefab.name;
			Vector3 Size = new nullity.Vector3(Mesh.bounds.size);
			_sizeX = Size.X;
			_sizeY = Size.Y;
			_sizeZ = Size.Z;
		}
		public Model() : base("void")
		{
			_gameobject.AddComponent<MeshFilter>();
			_gameobject.AddComponent<MeshRenderer>();
			_sizeX = 16;
			_sizeY = 16;
			_sizeZ = 16;
		}
	
		public void SetModel(Model mod)
		{
			if(mod!=null)
			{
				_Material = mod.Material;
				_Mesh = mod.Mesh;
			}
			Vector3 Size = new nullity.Vector3(Mesh.bounds.size);
			_sizeX = Size.X;
			_sizeY = Size.Y;
			_sizeZ = Size.Z;
		}
		public void SetModel(string name)
		{
			Model mod = ServiceLocator.Get<AssetManager>().GetModel(name);
			SetModel(mod);
		}
		public void SetModel()
		{
			_Mesh = null;
			_Material = null;
			_sizeX = 16;
			_sizeY = 16;
			_sizeZ = 16;
		}
	}
}