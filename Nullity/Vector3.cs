using UnityEngine;
namespace nullity
{
    public class Vector3
	{
		private UnityEngine.Vector3 _v;
		public float X{get=>_v.x;}
		public float Y{get=>_v.y; }
		public float Z{get=>_v.z; }
		public UnityEngine.Vector3 ToUnity{get=> _v;}
		public static nullity.Vector3 zero = new nullity.Vector3(0,0,0);
		public static nullity.Vector3 left = new nullity.Vector3(-1,0,0);
		public static nullity.Vector3 right = new nullity.Vector3(1,0,0);
		public static nullity.Vector3 forward = new nullity.Vector3(0,0,1);
		public static nullity.Vector3 backward = new nullity.Vector3(0,0,-1);
		public static nullity.Vector3 up = new nullity.Vector3(0,1,0);
		public static nullity.Vector3 down = new nullity.Vector3(0,-1,0);
		public Vector3(float px,float py,float pz)
		{
			_v = new UnityEngine.Vector3(px,py,pz);
		}
		public Vector3(UnityEngine.Vector3 v)
		{
			_v = v;
		}
		
		public static nullity.Vector3 operator +(nullity.Vector3 v,nullity.Vector3 v2)
		{
			nullity.Vector3 lv= new nullity.Vector3(
			v.X + v2.X,
			v.Y + v2.Y,
			v.Z + v2.Z);
			return lv;
		}
		public static nullity.Vector3 operator -(nullity.Vector3 v,nullity.Vector3 v2)
		{
			nullity.Vector3 lv= new nullity.Vector3(
			v.X - v2.X,
			v.Y - v2.Y,
			v.Z - v2.Z);
			return lv;
		}
		public static nullity.Vector3 operator *(nullity.Vector3 vec,float f)
		{
			nullity.Vector3 lv= new nullity.Vector3(
			vec.X * f,
			vec.Y * f,
			vec.Z * f);
			return lv;
		}
	}
}