
using UnityEngine;
namespace nullity
{
    public class Mouse
    {
        public static float getX()
		{
			return Input.mousePosition.x;
		}
		public static float getY()
		{
			return Input.mousePosition.y;
		}
		public static bool isDown(int i)
		{
			if(i>-1 && i<3)
				return Input.GetMouseButton(i);
			return false;
		}
		public static bool isPress(int i)
		{
			if(i>-1 && i<3)
				return Input.GetMouseButtonDown(i);
			return false;
		}
		public static bool isUp(int i)
		{
			if(i>-1 && i<3)
				return Input.GetMouseButtonUp(i);
			return false;
		}
    }
}