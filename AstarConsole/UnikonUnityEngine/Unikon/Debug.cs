using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Debug
	{
		

		public static void DrawLine(Vector3 start, Vector3 end, [DefaultValue("Color.white")] Color color, [DefaultValue("0.0f")] float duration, [DefaultValue("true")] bool depthTest)
		{
		}

		public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
		{
		}

		public static void DrawLine(Vector3 start, Vector3 end, Color color)
		{
		}

		public static void DrawLine(Vector3 start, Vector3 end)
		{
		}

		public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
		{
		}

		public static void DrawRay(Vector3 start, Vector3 dir, Color color)
		{
		}

		public static void DrawRay(Vector3 start, Vector3 dir)
		{
		}

		public static void DrawRay(Vector3 start, Vector3 dir, [DefaultValue("Color.white")] Color color, [DefaultValue("0.0f")] float duration, [DefaultValue("true")] bool depthTest)
		{
			Debug.DrawLine(start, start + dir, color, duration, depthTest);
		}

		public static  void Break()
        {

        }

		public static  void DebugBreak()
        {

        }


        public enum LogType
        {
            Error,
            Assert,
            Warning,
            Log,
            Exception
        }


        private static ConsoleColor tmpColor;
        protected static void Print(LogType logType,  object message, string stackTrack = "")
        {

            tmpColor = Console.ForegroundColor;
            switch (logType)
            {
                case LogType.Exception:
                case LogType.Error:
                case LogType.Assert:
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Diagnostics.Debug.Print("\n[Error]============\n" + message.ToString() + "\n" + stackTrack + "\n\n");
                    if(string.IsNullOrEmpty(stackTrack))
                        System.Diagnostics.Debug.Print(Environment.StackTrace);
                    break;
                case LogType.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    System.Diagnostics.Debug.Print("\n[Warning]============\n" + message.ToString() + "\n" + stackTrack + "\n\n");

                    System.Diagnostics.Debug.Print(Environment.StackTrace);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Diagnostics.Debug.Print("\n[Log]============\n" + message.ToString() + "\n" + stackTrack + "\n\n");

                    System.Diagnostics.Debug.Print(Environment.StackTrace);
                    break;
            }

            Console.WriteLine(message);

            switch (logType)
            {
                case LogType.Exception:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(stackTrack);
                    break;

                case LogType.Error:
                case LogType.Assert:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(Environment.StackTrace);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(Environment.StackTrace);
                    break;
            }

            Console.ForegroundColor = tmpColor;

        }

        public static void Log(object message)
		{
            Print(LogType.Log, message);

        }

		public static void Log(object message, Object context)
        {
            Print(LogType.Log, message);
        }

		public static void LogFormat(string format, params object[] args)
        {
            Print(LogType.Log, string.Format(format, args));
        }

		public static void LogFormat(Object context, string format, params object[] args)
        {
            Print(LogType.Log, string.Format(format, args));
        }

		public static void LogError(object message)
        {
            Print(LogType.Error, message);
        }

		public static void LogError(object message, Object context)
        {
            Print(LogType.Error, message);
        }

		public static void LogErrorFormat(string format, params object[] args)
        {
            Print(LogType.Error, string.Format(format, args));
        }

		public static void LogErrorFormat(Object context, string format, params object[] args)
        {
            Print(LogType.Error, string.Format(format, args));
        }

		public static  void ClearDeveloperConsole()
        {

        }

		public static void LogException(Exception exception)
        {
            Print(LogType.Exception, exception.Message, exception.StackTrace);
        }

		public static void LogException(Exception exception, Object context)
        {
            Print(LogType.Exception, exception.Message, exception.StackTrace);
        }

		public static void LogWarning(object message)
        {
            Print(LogType.Warning, message);
        }

		public static void LogWarning(object message, Object context)
        {
            Print(LogType.Warning, message);
        }

		public static void LogWarningFormat(string format, params object[] args)
        {
            Print(LogType.Warning, string.Format(format, args));
        }

		public static void LogWarningFormat(Object context, string format, params object[] args)
        {
            Print(LogType.Warning, string.Format(format, args));
        }

		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, Object context)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, object message)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, string message)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, object message, Object context)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, string message, Object context)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void AssertFormat(bool condition, string format, params object[] args)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void AssertFormat(bool condition, Object context, string format, params object[] args)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertion(object message)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertion(object message, Object context)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertionFormat(string format, params object[] args)
		{
		}

		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertionFormat(Object context, string format, params object[] args)
		{
		}


		[Conditional("UNITY_ASSERTIONS"), Obsolete("Assert(bool, string, params object[]) is obsolete. Use AssertFormat(bool, string, params object[]) (UnityUpgradable) -> AssertFormat(*)", true)]
		public static void Assert(bool condition, string format, params object[] args)
		{
		}
	}
}
