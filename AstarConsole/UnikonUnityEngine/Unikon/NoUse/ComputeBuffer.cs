using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using UnityEngine.Scripting;

namespace UnityEngine
{
	public sealed class ComputeBuffer : IDisposable
	{
		internal IntPtr m_Ptr;

		public  int count
		{
			get;
		}

		public  int stride
		{
			get;
		}

		public ComputeBuffer(int count, int stride) : this(count, stride, ComputeBufferType.Default, 3)
		{
		}

		public ComputeBuffer(int count, int stride, ComputeBufferType type) : this(count, stride, type, 3)
		{
		}

		internal ComputeBuffer(int count, int stride, ComputeBufferType type, int stackDepth)
		{
		}

		~ComputeBuffer()
		{
			this.Dispose(false);
		}

		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		private void Dispose(bool disposing)
		{
			this.m_Ptr = IntPtr.Zero;
		}

		

		public void Release()
		{
			this.Dispose();
		}

		[SecuritySafeCritical]
		public void SetData(Array data)
		{
			//this.InternalSetData(data, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		//[SecurityCritical, GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		//private extern void InternalSetData(Array data, int elemSize);

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		//public extern void SetCounterValue(uint counterValue);

		//[SecuritySafeCritical]
		//public void GetData(Array data)
		//{
		//	this.InternalGetData(data, Marshal.SizeOf(data.GetType().GetElementType()));
		//}

		//[SecurityCritical, GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		//private extern void InternalGetData(Array data, int elemSize);

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		//public static extern void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffset);

		//public IntPtr GetNativeBufferPtr()
		//{
		//	IntPtr result;
		//	ComputeBuffer.INTERNAL_CALL_GetNativeBufferPtr(this, out result);
		//	return result;
		//}

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		//private static extern void INTERNAL_CALL_GetNativeBufferPtr(ComputeBuffer self, out IntPtr value);

		//[GeneratedByOldBindingsGenerator, ThreadAndSerializationSafe]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		//internal extern string GetFileName();

		//[GeneratedByOldBindingsGenerator, ThreadAndSerializationSafe]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		//internal extern int GetLineNumber();

		//internal void SaveCallstack(int stackDepth)
		//{
		//	StackFrame stackFrame = new StackFrame(stackDepth, true);
		//	this.SaveCallstack_Internal(stackFrame.GetFileName(), stackFrame.GetFileLineNumber());
		//}

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		//private extern void SaveCallstack_Internal(string fileName, int lineNumber);
	}
}
