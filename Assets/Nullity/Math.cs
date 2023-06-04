
using System.Diagnostics;

namespace nullity
{
    public class Math
    {    
        public const double PI = System.Math.PI;
        public static float ToRad = (float)PI/180;
        public static float ToDeg = 180/(float)PI;
        public static bool Collide(Model obj1,Model obj2)
        {  

            if(obj1!=null && obj2!=null)
            {
                if(obj1.PositionX-obj1.SizeX/2 < obj2.PositionX + obj2.SizeX/2 &&
                obj1.PositionY-obj1.SizeY/2 < obj2.PositionY + obj2.SizeY/2 &&
                obj1.PositionZ-obj1.SizeZ/2 < obj2.PositionZ + obj2.SizeZ/2 &&

                obj2.PositionX-obj2.SizeX/2 < obj1.PositionX + obj1.SizeX/2 &&
                obj2.PositionY-obj2.SizeY/2 < obj1.PositionY + obj1.SizeY/2 &&
                obj2.PositionZ-obj2.SizeZ/2 < obj1.PositionZ + obj1.SizeZ/2)
                {
                    return true;
                }
            }
            return false;
        }
        public static float Dist(Model obj1,Model obj2)
        {
            float distx = System.Math.Abs(obj1.PositionX-obj2.PositionX);
            float disty = System.Math.Abs(obj1.PositionY-obj2.PositionY);
            float distz = System.Math.Abs(obj1.PositionZ-obj2.PositionZ);
            return distx + disty + distz;
        }
        public static float DistX(Model obj1,Model obj2)
        {
            Debug.Print($"{System.Math.Abs(obj1.PositionX-obj2.PositionX)}");
            return System.Math.Abs(obj1.PositionX-obj2.PositionX);
        }
        public static float DistY(Model obj1,Model obj2)
        {
            Debug.Print($"{System.Math.Abs(obj1.PositionY-obj2.PositionY)}");
            return System.Math.Abs(obj1.PositionY-obj2.PositionY);
        }
        public static float DistZ(Model obj1,Model obj2)
        {
            Debug.Print($"{System.Math.Abs(obj1.PositionZ-obj2.PositionZ)}");
            return System.Math.Abs(obj1.PositionZ-obj2.PositionZ);
        }
    }
}