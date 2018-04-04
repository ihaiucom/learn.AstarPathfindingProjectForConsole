using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class RectOffset
	{


		public  int left
		{
			get;
			set;
		}

		public  int right
		{
			get;
			set;
		}

		public  int top
		{
			get;
			set;
		}

		public  int bottom
		{
			get;
			set;
		}

		public  int horizontal
		{
			get;
		}

		public  int vertical
		{
			get;
		}

		public RectOffset()
		{
			this.Init();
		}

		internal RectOffset(object sourceStyle, IntPtr source)
		{
		}

		public RectOffset(int left, int right, int top, int bottom)
		{
			this.Init();
			this.left = left;
			this.right = right;
			this.top = top;
			this.bottom = bottom;
		}

		private  void Init()
        {

        }

		private  void Cleanup()
        {
        }

		public Rect Add(Rect rect)
		{
            return new Rect(rect.x - left, rect.y - top, rect.width + left + right, rect.height + top + bottom);

		}

		public Rect Remove(Rect rect)
		{
            return new Rect(rect.x + left, rect.y + top, rect.width - left - right, rect.height - top - bottom);
		}

		~RectOffset()
        {
            this.Cleanup();
        }

		public override string ToString()
		{
			return UnityString.Format("RectOffset (l:{0} r:{1} t:{2} b:{3})", new object[]
			{
				this.left,
				this.right,
				this.top,
				this.bottom
			});
		}
	}
}
