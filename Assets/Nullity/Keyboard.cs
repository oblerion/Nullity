using UnityEngine;
namespace nullity
{
    public class Keyboard
    {
        public static bool isDown(string key)
		{
			return Input.GetKey(key);
		}
	   	public static bool isPress(string key)
		{
			return Input.GetKeyDown(key);
		}
		public static bool isUp(string key)
		{
			return Input.GetKeyUp(key);
		}
    }

}