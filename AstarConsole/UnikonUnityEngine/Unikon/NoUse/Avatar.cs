using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	public sealed class Avatar : Object
	{
		public  bool isValid
		{
			get;
		}

		public  bool isHuman
		{
			get;
		}

		private Avatar()
		{
		}

        internal void SetMuscleMinMax(int muscleId, float min, float max) { }

        internal  void SetParameter(int parameterId, float value) { }

        internal  float GetAxisLength(int humanId) { return 0; }

		internal Quaternion GetPreRotation(int humanId)
		{
			Quaternion result;
			Avatar.INTERNAL_CALL_GetPreRotation(this, humanId, out result);
			return result;
		}

        private static void INTERNAL_CALL_GetPreRotation(Avatar self, int humanId, out Quaternion value) { value = default(Quaternion); }

		internal Quaternion GetPostRotation(int humanId)
		{
			Quaternion result;
			Avatar.INTERNAL_CALL_GetPostRotation(this, humanId, out result);
			return result;
		}

        private static void INTERNAL_CALL_GetPostRotation(Avatar self, int humanId, out Quaternion value) { value = default(Quaternion); }

		internal Quaternion GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q)
		{
			Quaternion result;
			Avatar.INTERNAL_CALL_GetZYPostQ(this, humanId, ref parentQ, ref q, out result);
			return result;
		}

        private static void INTERNAL_CALL_GetZYPostQ(Avatar self, int humanId, ref Quaternion parentQ, ref Quaternion q, out Quaternion value) { value = default(Quaternion); }

		internal Quaternion GetZYRoll(int humanId, Vector3 uvw)
		{
			Quaternion result;
			Avatar.INTERNAL_CALL_GetZYRoll(this, humanId, ref uvw, out result);
			return result;
		}

        private static void INTERNAL_CALL_GetZYRoll(Avatar self, int humanId, ref Vector3 uvw, out Quaternion value) { value = default(Quaternion); }

		internal Vector3 GetLimitSign(int humanId)
		{
			Vector3 result;
			Avatar.INTERNAL_CALL_GetLimitSign(this, humanId, out result);
			return result;
		}

        private static void INTERNAL_CALL_GetLimitSign(Avatar self, int humanId, out Vector3 value) { value = default(Vector3); }
	}
}
