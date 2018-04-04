using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	public sealed class AnimationClip : Motion
	{
		public  float length
		{
			get;
		}

		internal  float startTime
		{
			get;
		}

		internal  float stopTime
        {
            get;
		}

		public  float frameRate
		{
			get;
			set;
		}

		public  WrapMode wrapMode
		{
			get;
			set;
		}

		public Bounds localBounds
		{
			get
			{
				Bounds result;
				this.INTERNAL_get_localBounds(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_localBounds(ref value);
			}
		}

		public  bool legacy
		{
			get;
			set;
		}

		public  bool humanMotion
		{
			get;
		}

		internal  bool empty
		{
			get;
		}

		public AnimationEvent[] events
		{
			get
			{
				return (AnimationEvent[])this.GetEventsInternal();
			}
			set
			{
				this.SetEventsInternal(value);
			}
		}

		public AnimationClip()
		{
			AnimationClip.Internal_CreateAnimationClip(this);
		}

        public void SampleAnimation(GameObject go, float time) { }

        private static void Internal_CreateAnimationClip([Writable] AnimationClip self) { }

        public void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve) { }

		public void EnsureQuaternionContinuity()
		{
			AnimationClip.INTERNAL_CALL_EnsureQuaternionContinuity(this);
		}

        private static  void INTERNAL_CALL_EnsureQuaternionContinuity(AnimationClip self) { }

		public void ClearCurves()
		{
			AnimationClip.INTERNAL_CALL_ClearCurves(this);
		}

        private static void INTERNAL_CALL_ClearCurves(AnimationClip self) { }

        private void INTERNAL_get_localBounds(out Bounds value) { value = default(Bounds); }

        private  void INTERNAL_set_localBounds(ref Bounds value) { }

		public void AddEvent(AnimationEvent evt)
		{
			if (evt == null)
			{
				throw new ArgumentNullException("evt");
			}
			this.AddEventInternal(evt);
		}

        internal void AddEventInternal(object evt) { }

        internal void SetEventsInternal(Array value) { }

        internal Array GetEventsInternal() { return null; }
	}
}
