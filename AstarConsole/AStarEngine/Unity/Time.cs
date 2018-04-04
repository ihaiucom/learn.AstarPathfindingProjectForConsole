# if !UNITY
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Time
{
    private static DateTime beginTime;

    private static float _time;

    public static float time
    {
        get
        {
            _time = (float)DateTime.Now.Subtract(beginTime).TotalSeconds;
            return _time;
        }
    }

    public static float realtimeSinceStartup
    {
        get
        {
            return time;
        }
    }

    public static float deltaTime = 0.02f;

    public static float fixedDeltaTime = 0.02f;
    public static void Init()
    {
        beginTime = DateTime.Now;
    }
}
#endif
