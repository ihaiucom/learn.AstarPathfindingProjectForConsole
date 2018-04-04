using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	public class Behaviour : Component
	{
		public  bool enabled
		{
			get;
			set;
		}

		public  bool isActiveAndEnabled
		{
			get;
		}
	}
}
