using UnityEngine;
namespace nullity
{
    public class MainCamera
	{
		// public static nullity.Vector3 Position
		// {
		// 	get=> new nullity.Vector3(Camera.main.transform.position);
		// 	set=>Camera.main.transform.position=new UnityEngine.Vector3(value.X,value.Y,value.Z);
		// }
		public static float PositionX{get=>Camera.main.transform.position.x;}
		public static float PositionY{get=>Camera.main.transform.position.y;}
		public static float PositionZ{get=>Camera.main.transform.position.z;}
		// public static nullity.Vector3 Rotation
        // {
        //     get=> new nullity.Vector3(Camera.main.transform.rotation.eulerAngles);
        //     set=>Camera.main.transform.rotation=Quaternion.Euler(value.X,value.Y,value.Z);
        // }
        public static void SetPosition(float x,float y,float z)
        {
			Camera.main.transform.position=new UnityEngine.Vector3(x,y,z);
		}
        public static void SetRotation(float x,float y,float z)
        {
			Camera.main.transform.rotation= Quaternion.Euler(x,y,z);
		}
        public static void Translate(float x,float y,float z)
        {
			Camera.main.transform.Translate(x,y,z); //position += new UnityEngine.Vector3(x,y,z);
		}
		public static Camera Camera {get=>Camera.main;}
	}
}
	