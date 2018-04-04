using System;
using System.Collections.Generic;
/** 
* ==============================================================================
*  @Author      	曾峰(zengfeng75@qq.com) 
*  @Web      		http://blog.ihaiu.com
*  @CreateTime      4/2/2018 11:29:38 AM
*  @Description:    
* ==============================================================================
*/
namespace UnityEngine
{
    public class Random
    {
        private static readonly System.Random random = new System.Random();


        public static float value
        {
           get
            {
                return Range(0f, 1f);
            }
        }

        public static UInt64 RandUInt64()
        {
            var bytes = new byte[8];
            random.NextBytes(bytes);
            return BitConverter.ToUInt64(bytes, 0);
        }

        public static Int64 RandInt64()
        {
            var bytes = new byte[8];
            random.NextBytes(bytes);
            return BitConverter.ToInt64(bytes, 0);
        }

        public static int Range(int min, int max)
        {
            int value = random.Next(min, max);
            return value;
        }

        public static float Range(float min, float max)
        {
            float value = Range((int)(min * 1000), (int)(max * 1000)) / 1000f;
            return value;
        }


        public static Vector3 onUnitSphere
        {
            get
            {
                float z = Range(-1.0f, 1.0f);
                float a = Range(0.0f, 2.0F * Mathf.PI);

                float r = Mathf.Sqrt(1.0f - z * z);

                float x = r * Mathf.Cos(a);
                float y = r * Mathf.Sin(a);

                return new Vector3(x, y, z);
            }
        }


       
    }
}
