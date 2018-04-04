using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	public sealed class AvatarBuilder
	{
		public static Avatar BuildHumanAvatar(GameObject go, object humanDescription)
		{
			if (go == null)
			{
				throw new NullReferenceException();
			}
			return AvatarBuilder.BuildHumanAvatarMono(go, humanDescription);
		}

		private static Avatar BuildHumanAvatarMono(GameObject go, object monoHumanDescription)
		{
			return AvatarBuilder.INTERNAL_CALL_BuildHumanAvatarMono(go, ref monoHumanDescription);
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Avatar INTERNAL_CALL_BuildHumanAvatarMono(GameObject go, ref object monoHumanDescription);

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Avatar BuildGenericAvatar(GameObject go, string rootMotionTransformName);
	}
}
