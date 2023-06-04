namespace nullity
{
    public class Debug
    {
        private static bool _active=true; 
        public static bool Active{set=>_active=value;} 
        public static void Print(string str)
        {
            if(_active)
            UnityEngine.Debug.Log(str);
        }
        public static void Warning(string str)
        {
            if(_active)
            UnityEngine.Debug.LogWarning(str);
        }
        public static void Error(string str)
        {
            if(_active)
            UnityEngine.Debug.LogError(str);
        }
    }
}