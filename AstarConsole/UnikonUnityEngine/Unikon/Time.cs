using System;
using System.Collections.Generic;
/** 
* ==============================================================================
*  @Author      	曾峰(zengfeng75@qq.com) 
*  @Web      		http://blog.ihaiu.com
*  @CreateTime      3/23/2018 7:16:52 PM
*  @Description:    
* ==============================================================================
*/
namespace UnityEngine
{
    public class Time
    {
        public static float deltaTime = 0.033f;

        public static  float time
        {
            get;
            set;
        }

        public static  float timeSinceLevelLoad
        {
            get;
            set;
        }

        public static  float fixedTime
        {
            get;
            set;
        }

        public static  float unscaledTime
        {
            get;
        }

        public static  float fixedUnscaledTime
        {
            get;
        }

        public static  float unscaledDeltaTime
        {
            get;
        }

        public static  float fixedUnscaledDeltaTime
        {
            get;
        }

        public static  float fixedDeltaTime
        {
            get;
            set;
        }

        public static  float maximumDeltaTime
        {
            get;
            set;
        }

        public static  float smoothDeltaTime
        {
            get;
        }

        public static  float maximumParticleDeltaTime
        {
            get;
            set;
        }

        public static  float timeScale
        {
            get;
            set;
        }

        public static  int frameCount
        {
            get;
        }

        public static  int renderedFrameCount
        {
            get;
        }

        public static  float realtimeSinceStartup
        {
            get;
        }

        public static  int captureFramerate
        {
            get;
            set;
        }

        public static  bool inFixedTimeStep
        {
            get;
        }
    }

}
