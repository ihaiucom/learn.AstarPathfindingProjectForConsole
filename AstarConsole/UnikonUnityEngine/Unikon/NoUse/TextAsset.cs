using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	public class TextAsset : Object
	{
		public string text
		{
			get;
		}

		public byte[] bytes
		{
			get;
		}

		public override string ToString()
		{
			return this.text;
		}
	}
}
