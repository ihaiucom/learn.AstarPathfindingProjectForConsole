using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode]
	[StructLayout(LayoutKind.Sequential)]
	public class AsyncOperation : YieldInstruction
	{

        public  bool isDone;

        public  float progress = 0;

        public int priority;

        public bool allowSceneActivation;


		~AsyncOperation()
		{
		}
	}
}
