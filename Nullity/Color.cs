using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace nullity
{
    public class Color
	{
		private float _r=1;
		private float _g=1;
		private float _b=1;
		private float _a=1;
		
		public static nullity.Color black = new nullity.Color(UnityEngine.Color.black);
		public static nullity.Color blue = new nullity.Color(UnityEngine.Color.blue);
		public static nullity.Color clear = new nullity.Color(UnityEngine.Color.clear);
		public static nullity.Color cyan = new nullity.Color(UnityEngine.Color.cyan);
		public static nullity.Color gray = new nullity.Color(UnityEngine.Color.gray);
		public static nullity.Color green = new nullity.Color(UnityEngine.Color.green);
		public static nullity.Color magenta = new nullity.Color(UnityEngine.Color.magenta);
		public static nullity.Color red = new nullity.Color(UnityEngine.Color.red);
		public static nullity.Color red_alert = new nullity.Color(0.6f,0,0,1);
		public static nullity.Color white = new nullity.Color(UnityEngine.Color.white);
		public static nullity.Color yellow =new nullity.Color(UnityEngine.Color.yellow);
		public Color(float r,float g,float b,float a)
		{
			_r=r;
			_g=g;
			_b=b;
			_a=a;
		}
		public Color(float r,float g,float b)
		{
			_r=r;
			_g=g;
			_b=b;
		}
		public Color(UnityEngine.Color col)
		{
			_r=col.r;
			_g=col.g;
			_b=col.b;
			_a=col.a;
		}
		public UnityEngine.Color ToUnity()
		{
			return new UnityEngine.Color(_r,_g,_b,_a);
		}
	}
}