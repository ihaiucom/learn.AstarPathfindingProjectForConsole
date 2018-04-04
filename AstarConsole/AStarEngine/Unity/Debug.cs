#if !UNITY
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Debug
{

    public static void LogError(string s)
    {

    }

    public static void LogError(System.Exception s)
    {

    }

    public static void Log(string s)
    {

    }

    public static void Log(Vector3 s)
    {
        Console.WriteLine("x:" + s.x + "--y:" + s.y + "--z:" + s.z);
    }

    public static void LogWarning(string s)
    {

    }

    internal static void DrawLine(Vector3 vector31, Vector3 vector32, Color white)
    {

    }

    internal static void DrawRay(Vector3 position, Vector3 vector3, Color red)
    {
        
    }

    internal static void DrawLine(Vector3 vector31, Vector3 vector32, Color yellow, int v)
    {
        
    }

    internal static void DrawLine(Vector3 prev, Vector3 vector3)
    {
        
    }

    internal static void LogException(Exception e)
    {
       
    }
}

#endif