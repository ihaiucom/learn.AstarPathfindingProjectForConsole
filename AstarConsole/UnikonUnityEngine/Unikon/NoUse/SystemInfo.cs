using System;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	public sealed class SystemInfo
	{
		public const string unsupportedIdentifier = "n/a";

        public static  float batteryLevel;

		public static  BatteryStatus batteryStatus
		{
			get;
		}

		public static  string operatingSystem
		{
			get;
		}

		public static  OperatingSystemFamily operatingSystemFamily
		{
			get;
		}

		public static  string processorType
		{
			get;
		}

		public static  int processorFrequency
		{
			get;
		}

        public static int processorCount = 2;

        public static  int systemMemorySize = 2024;

        public static int graphicsMemorySize;

        public static string graphicsDeviceName = "";

        public static string graphicsDeviceVendor;

		public static extern int graphicsDeviceID
		{
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		public static extern int graphicsDeviceVendorID
		{
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		public static  GraphicsDeviceType graphicsDeviceType
		{
			get;
		}

		public static  bool graphicsUVStartsAtTop
		{
			get;
		}

		public static  string graphicsDeviceVersion
		{
			get;
		}

		public static  int graphicsShaderLevel
		{
			get;
		}

		[Obsolete("graphicsPixelFillrate is no longer supported in Unity 5.0+.")]
		public static int graphicsPixelFillrate
		{
			get
			{
				return -1;
			}
		}

		[Obsolete("Vertex program support is required in Unity 5.0+")]
		public static bool supportsVertexPrograms
		{
			get
			{
				return true;
			}
		}

		public static  bool graphicsMultiThreaded
		{
			get;
		}

		public static  bool supportsShadows
		{
			get;
		}

		public static extern bool supportsRawShadowDepthSampling
		{
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[Obsolete("supportsRenderTextures always returns true, no need to call it")]
		public static extern bool supportsRenderTextures
		{
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		public static extern bool supportsMotionVectors
		{
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		public static extern bool supportsRenderToCubemap
		{
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		public static extern bool supportsImageEffects
		{
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		public static extern bool supports3DTextures
		{
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		public static extern bool supports2DArrayTextures
		{
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		public static extern bool supports3DRenderTextures
		{
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		public static extern bool supportsCubemapArrayTextures
		{
			[GeneratedByOldBindingsGenerator]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		//public static extern CopyTextureSupport copyTextureSupport
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//public static extern bool supportsComputeShaders
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//public static extern bool supportsInstancing
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//public static extern bool supportsSparseTextures
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//public static extern int supportedRenderTargetCount
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//public static extern bool usesReversedZBuffer
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//[Obsolete("supportsStencil always returns true, no need to call it")]
		//public static extern int supportsStencil
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//public static extern NPOTSupport npotSupport
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//public static extern string deviceUniqueIdentifier
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//public static extern string deviceName
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//public static extern string deviceModel
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//public static extern bool supportsAccelerometer
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//public static extern bool supportsGyroscope
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//public static extern bool supportsLocationService
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//public static extern bool supportsVibration
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//public static extern bool supportsAudio
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//public static extern DeviceType deviceType
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//public static extern int maxTextureSize
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//public static extern int maxCubemapSize
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//internal static extern int maxRenderTextureSize
		//{
		//	[GeneratedByOldBindingsGenerator]
		//	[MethodImpl(MethodImplOptions.InternalCall)]
		//	get;
		//}

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		//public static extern bool SupportsRenderTextureFormat(RenderTextureFormat format);

		//[GeneratedByOldBindingsGenerator]
		//[MethodImpl(MethodImplOptions.InternalCall)]
		//public static extern bool SupportsTextureFormat(TextureFormat format);
	}
}
