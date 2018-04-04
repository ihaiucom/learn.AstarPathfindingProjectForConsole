using System;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	public class Texture : Object
	{
		public static  int masterTextureLimit
		{
			get;
			set;
		}

		public static  AnisotropicFiltering anisotropicFiltering
		{
			get;
			set;
		}

		public virtual int width
		{
            get;
            set;
		}

		public virtual int height
        {
            get;
            set;
        }

		public virtual TextureDimension dimension
        {
            get;
            set;
        }

		public  FilterMode filterMode
		{
			get;
			set;
		}

		public  int anisoLevel
		{
			get;
			set;
		}

		public  TextureWrapMode wrapMode
		{
			get;
			set;
		}

		public  float mipMapBias
		{
			get;
			set;
		}

        public Vector2 texelSize
        {
            get;
            set;
        }

        public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax) { }


        public  int GetNativeTextureID() { return 0; }
	}
}
