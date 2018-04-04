using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Profiling
{
	public sealed class Profiler
	{
		public static  bool supported
		{
			get;
		}

		public static  string logFile
		{
			get;
			set;
		}

		public static  bool enableBinaryLog
        { 
			get;
			set;
		}

		public static  bool enabled
		{
			get;
			set;
		}

		[Obsolete("maxNumberOfSamplesPerFrame is no longer needed, as the profiler buffers auto expand as needed")]
		public static  int maxNumberOfSamplesPerFrame
		{
			get;
			set;
		}

		public static  uint usedHeapSize
		{
			get;
		}

		public static  long usedHeapSizeLong
		{
			get;
		}

		private Profiler()
		{
		}

        public static void AddFramesFromFile(string file) { }

		public static void BeginSample(string name)
		{
		}

		public static  void BeginSample(string name, UnityEngine.Object targetObject)
        {

        }


		public static  void EndSample()
        {

        }

		public static int GetRuntimeMemorySize(UnityEngine.Object o)
		{
			return (int)Profiler.GetRuntimeMemorySizeLong(o);
		}

		public static  long GetRuntimeMemorySizeLong(UnityEngine.Object o)
        {
            return 0;
        }

		public static uint GetMonoHeapSize()
		{
			return (uint)Profiler.GetMonoHeapSizeLong();
		}

        public static  long GetMonoHeapSizeLong() { return 0; }

		public static uint GetMonoUsedSize()
		{
			return (uint)Profiler.GetMonoUsedSizeLong();
		}

        public static  long GetMonoUsedSizeLong() { return 0; }

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		//public static extern bool SetTempAllocatorRequestedSize(uint size);

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		//public static extern uint GetTempAllocatorSize();

		[Obsolete("GetTotalAllocatedMemory has been deprecated since it is limited to 4GB. Please use GetTotalAllocatedMemoryLong() instead.")]
		public static uint GetTotalAllocatedMemory()
		{
			return (uint)Profiler.GetTotalAllocatedMemoryLong();
		}
        
        public static  long GetTotalAllocatedMemoryLong() { return 0; }

		[Obsolete("GetTotalUnusedReservedMemory has been deprecated since it is limited to 4GB. Please use GetTotalUnusedReservedMemoryLong() instead.")]
		public static uint GetTotalUnusedReservedMemory()
		{
			return (uint)Profiler.GetTotalUnusedReservedMemoryLong();
		}
        
        public static long GetTotalUnusedReservedMemoryLong() { return 0; }

		[Obsolete("GetTotalReservedMemory has been deprecated since it is limited to 4GB. Please use GetTotalReservedMemoryLong() instead.")]
		public static uint GetTotalReservedMemory()
		{
			return (uint)Profiler.GetTotalReservedMemoryLong();
		}
        
        public static long GetTotalReservedMemoryLong() { return 0; }
	}
}
