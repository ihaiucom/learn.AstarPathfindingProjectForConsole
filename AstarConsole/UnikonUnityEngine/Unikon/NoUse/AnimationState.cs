using System;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	public sealed class AnimationState : TrackedReference
	{
		public  bool enabled
		{
			get;
			set;
		}

		public  float weight
		{
			get;
			set;
		}

		public  WrapMode wrapMode
		{
			get;
			set;
		}

		public  float time
		{
			get;
			set;
		}

		public  float normalizedTime
		{
			get;
			set;
		}

		public  float speed
		{
			get;
			set;
		}

		public  float normalizedSpeed
		{
			get;
			set;
		}

		public  float length
		{
			get;
		}

		public  int layer
		{
			get;
			set;
		}

		public  AnimationClip clip
		{
			get;
		}

		public  string name
		{
			get;
			set;
		}

		public  AnimationBlendMode blendMode
		{
			get;
			set;
		}

        public void AddMixingTransform(Transform mix, [DefaultValue("true")] bool recursive) { }

		[ExcludeFromDocs]
		public void AddMixingTransform(Transform mix)
		{
			bool recursive = true;
			this.AddMixingTransform(mix, recursive);
		}

        public  void RemoveMixingTransform(Transform mix) { }
	}
}
