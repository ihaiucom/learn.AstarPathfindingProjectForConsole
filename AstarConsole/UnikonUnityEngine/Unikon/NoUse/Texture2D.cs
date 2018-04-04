using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	public sealed class Texture2D : Texture
	{
		[Flags]
		public enum EXRFlags
		{
			None = 0,
			OutputAsFloat = 1,
			CompressZIP = 2,
			CompressRLE = 4,
			CompressPIZ = 8
		}

		public  int mipmapCount
		{
			
			get;
		}

		public  TextureFormat format
		{
			
			get;
		}

		public static  Texture2D whiteTexture
		{
			
			get;
		}

		public static  Texture2D blackTexture
		{
			
			get;
		}

		public  bool alphaIsTransparency
		{
			
			get;
			
			set;
		}

		public Texture2D(int width, int height)
		{
			Texture2D.Internal_Create(this, width, height, TextureFormat.RGBA32, true, false, IntPtr.Zero);
		}

		public Texture2D(int width, int height, TextureFormat format, bool mipmap)
		{
			Texture2D.Internal_Create(this, width, height, format, mipmap, false, IntPtr.Zero);
		}

		public Texture2D(int width, int height, TextureFormat format, bool mipmap, bool linear)
		{
			Texture2D.Internal_Create(this, width, height, format, mipmap, linear, IntPtr.Zero);
		}

		internal Texture2D(int width, int height, TextureFormat format, bool mipmap, bool linear, IntPtr nativeTex)
		{
			Texture2D.Internal_Create(this, width, height, format, mipmap, linear, nativeTex);
		}

				private static  void Internal_Create([Writable] Texture2D mono, int width, int height, TextureFormat format, bool mipmap, bool linear, IntPtr nativeTex) 
{

}

		public static Texture2D CreatealTexture(int width, int height, TextureFormat format, bool mipmap, bool linear, IntPtr nativeTex)
		{
			return new Texture2D(width, height, format, mipmap, linear, nativeTex);
		}

				public  void UpdatealTexture(IntPtr nativeTex) 
{

}

		public void SetPixel(int x, int y, Color color)
		{
			Texture2D.INTERNAL_CALL_SetPixel(this, x, y, ref color);
		}

				private static  void INTERNAL_CALL_SetPixel(Texture2D self, int x, int y, ref Color color) 
{

}

		public Color GetPixel(int x, int y)
		{
			Color result;
			Texture2D.INTERNAL_CALL_GetPixel(this, x, y, out result);
			return result;
		}

				private static  void INTERNAL_CALL_GetPixel(Texture2D self, int x, int y, out Color value) 
{

            value = default(Color32);
        }

		public Color GetPixelBilinear(float u, float v)
		{
			Color result;
			Texture2D.INTERNAL_CALL_GetPixelBilinear(this, u, v, out result);
			return result;
		}

				private static  void INTERNAL_CALL_GetPixelBilinear(Texture2D self, float u, float v, out Color value) 
{
            value = default(Color32);
}

		[ExcludeFromDocs]
		public void SetPixels(Color[] colors)
		{
			int miplevel = 0;
			this.SetPixels(colors, miplevel);
		}

		public void SetPixels(Color[] colors, [DefaultValue("0")] int miplevel)
		{
			int num = this.width >> miplevel;
			if (num < 1)
			{
				num = 1;
			}
			int num2 = this.height >> miplevel;
			if (num2 < 1)
			{
				num2 = 1;
			}
			this.SetPixels(0, 0, num, num2, colors, miplevel);
		}

				public  void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, [DefaultValue("0")] int miplevel) 
{

}

		[ExcludeFromDocs]
		public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors)
		{
			int miplevel = 0;
			this.SetPixels(x, y, blockWidth, blockHeight, colors, miplevel);
		}

				private  void SetAllPixels32(Color32[] colors, int miplevel) 
{

}

				private  void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) 
{

}

		[ExcludeFromDocs]
		public void SetPixels32(Color32[] colors)
		{
			int miplevel = 0;
			this.SetPixels32(colors, miplevel);
		}

		public void SetPixels32(Color32[] colors, [DefaultValue("0")] int miplevel)
		{
			this.SetAllPixels32(colors, miplevel);
		}

		[ExcludeFromDocs]
		public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors)
		{
			int miplevel = 0;
			this.SetPixels32(x, y, blockWidth, blockHeight, colors, miplevel);
		}

		public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, [DefaultValue("0")] int miplevel)
		{
			this.SetBlockOfPixels32(x, y, blockWidth, blockHeight, colors, miplevel);
		}

				public  bool LoadImage(byte[] data, [DefaultValue("false")] bool markNonReadable) 
{
            return false;
}

		[ExcludeFromDocs]
		public bool LoadImage(byte[] data)
		{
			bool markNonReadable = false;
			return this.LoadImage(data, markNonReadable);
		}

				private  void LoadRawTextureData_ImplArray(byte[] data) 
{

}

				private  void LoadRawTextureData_ImplPointer(IntPtr data, int size) 
{

}

		public void LoadRawTextureData(byte[] data)
		{
			this.LoadRawTextureData_ImplArray(data);
		}

		public void LoadRawTextureData(IntPtr data, int size)
		{
			this.LoadRawTextureData_ImplPointer(data, size);
		}

				public  byte[] GetRawTextureData() 
{

            return new byte[] { };
        }

		[ExcludeFromDocs]
		public Color[] GetPixels()
		{
			int miplevel = 0;
			return this.GetPixels(miplevel);
		}

		public Color[] GetPixels([DefaultValue("0")] int miplevel)
		{
			int num = this.width >> miplevel;
			if (num < 1)
			{
				num = 1;
			}
			int num2 = this.height >> miplevel;
			if (num2 < 1)
			{
				num2 = 1;
			}
			return this.GetPixels(0, 0, num, num2, miplevel);
		}

				public  Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, [DefaultValue("0")] int miplevel) 
{

            return new Color[] { };
        }

		[ExcludeFromDocs]
		public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight)
		{
			int miplevel = 0;
			return this.GetPixels(x, y, blockWidth, blockHeight, miplevel);
		}

				public  Color32[] GetPixels32([DefaultValue("0")] int miplevel) 
{
            return new Color32[] { };
}

		[ExcludeFromDocs]
		public Color32[] GetPixels32()
		{
			int miplevel = 0;
			return this.GetPixels32(miplevel);
		}

				public  void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable) 
{

}

		[ExcludeFromDocs]
		public void Apply(bool updateMipmaps)
		{
			bool makeNoLongerReadable = false;
			this.Apply(updateMipmaps, makeNoLongerReadable);
		}

		[ExcludeFromDocs]
		public void Apply()
		{
			bool makeNoLongerReadable = false;
			bool updateMipmaps = true;
			this.Apply(updateMipmaps, makeNoLongerReadable);
		}

				public  bool Resize(int width, int height, TextureFormat format, bool hasMipMap) 
{
            return false;
}

		public bool Resize(int width, int height)
		{
			return this.Internal_ResizeWH(width, height);
		}

				private  bool Internal_ResizeWH(int width, int height) 
{
            return false;
}

		public void Compress(bool highQuality)
		{
			Texture2D.INTERNAL_CALL_Compress(this, highQuality);
		}

				private static  void INTERNAL_CALL_Compress(Texture2D self, bool highQuality) 
{

}

				public  Rect[] PackTextures(Texture2D[] textures, int padding, [DefaultValue("2048")] int maximumAtlasSize, [DefaultValue("false")] bool makeNoLongerReadable) 
{
            return new Rect[] { };
}

		[ExcludeFromDocs]
		public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize)
		{
			bool makeNoLongerReadable = false;
			return this.PackTextures(textures, padding, maximumAtlasSize, makeNoLongerReadable);
		}

		[ExcludeFromDocs]
		public Rect[] PackTextures(Texture2D[] textures, int padding)
		{
			bool makeNoLongerReadable = false;
			int maximumAtlasSize = 2048;
			return this.PackTextures(textures, padding, maximumAtlasSize, makeNoLongerReadable);
		}

		public static bool GenerateAtlas(Vector2[] sizes, int padding, int atlasSize, List<Rect> results)
		{
			if (sizes == null)
			{
				throw new ArgumentException("sizes array can not be null");
			}
			if (results == null)
			{
				throw new ArgumentException("results list cannot be null");
			}
			if (padding < 0)
			{
				throw new ArgumentException("padding can not be negative");
			}
			if (atlasSize <= 0)
			{
				throw new ArgumentException("atlas size must be positive");
			}
			results.Clear();
			bool result;
			if (sizes.Length == 0)
			{
				result = true;
			}
			else
			{
				Texture2D.GenerateAtlasInternal(sizes, padding, atlasSize, results);
				result = (results.Count != 0);
			}
			return result;
		}

				private static  void GenerateAtlasInternal(Vector2[] sizes, int padding, int atlasSize, object resultList) 
{

}

		public void ReadPixels(Rect source, int destX, int destY, [DefaultValue("true")] bool recalculateMipMaps)
		{
			Texture2D.INTERNAL_CALL_ReadPixels(this, ref source, destX, destY, recalculateMipMaps);
		}

		[ExcludeFromDocs]
		public void ReadPixels(Rect source, int destX, int destY)
		{
			bool recalculateMipMaps = true;
			Texture2D.INTERNAL_CALL_ReadPixels(this, ref source, destX, destY, recalculateMipMaps);
		}

				private static  void INTERNAL_CALL_ReadPixels(Texture2D self, ref Rect source, int destX, int destY, bool recalculateMipMaps) 
{

}

				public  byte[] EncodeToPNG() 
{
            return new byte[] { };
}

				public  byte[] EncodeToJPG(int quality)
        {
            return new byte[] { };

        }

		public byte[] EncodeToJPG()
		{
			return this.EncodeToJPG(75);
		}

				public  byte[] EncodeToEXR([DefaultValue("EXRFlags.None")] Texture2D.EXRFlags flags) 
{

            return new byte[] { };
        }

		[ExcludeFromDocs]
		public byte[] EncodeToEXR()
		{
			Texture2D.EXRFlags flags = Texture2D.EXRFlags.None;
			return this.EncodeToEXR(flags);
		}
	}
}
