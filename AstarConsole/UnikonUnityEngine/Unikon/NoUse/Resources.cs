using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	public sealed class Resources
	{
		internal static T[] ConvertObjects<T>(Object[] rawObjects) where T : Object
		{
			T[] result;
			if (rawObjects == null)
			{
				result = null;
			}
			else
			{
				T[] array = new T[rawObjects.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = (T)((object)rawObjects[i]);
				}
				result = array;
			}
			return result;
		}

		public static  Object[] FindObjectsOfTypeAll(Type type)
        {
            return new Object[] { };
        }

		public static T[] FindObjectsOfTypeAll<T>() where T : Object
		{
			return Resources.ConvertObjects<T>(Resources.FindObjectsOfTypeAll(typeof(T)));
		}

		public static Object Load(string path)
		{
			return Resources.Load(path, typeof(Object));
		}

		public static T Load<T>(string path) where T : Object
		{
			return (T)((object)Resources.Load(path, typeof(T)));
		}

		public static  Object Load(string path, Type systemTypeInstance)
        {
            return null;
        }

		public static ResourceRequest LoadAsync(string path)
		{
			return Resources.LoadAsync(path, typeof(Object));
		}

		public static ResourceRequest LoadAsync<T>(string path) where T : Object
		{
			return Resources.LoadAsync(path, typeof(T));
		}

        public static ResourceRequest LoadAsync(string path, Type type) { return null; }

        public static Object[] LoadAll(string path, Type systemTypeInstance) { return new Object[] { }; }

		public static Object[] LoadAll(string path)
		{
			return Resources.LoadAll(path, typeof(Object));
		}

		public static T[] LoadAll<T>(string path) where T : Object
		{
			return Resources.ConvertObjects<T>(Resources.LoadAll(path, typeof(T)));
		}

		public static  Object GetBuiltinResource(Type type, string path)
        {
            return null;
        }

		public static T GetBuiltinResource<T>(string path) where T : Object
		{
			return (T)((object)Resources.GetBuiltinResource(typeof(T), path));
		}

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnloadAsset(Object assetToUnload);

		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern AsyncOperation UnloadUnusedAssets();

        public static Object LoadAssetAtPath(string assetPath, Type type)
		{
			return null;
		}

		[Obsolete("Use AssetDatabase.LoadAssetAtPath<T>() instead (UnityUpgradable) -> * [UnityEditor] UnityEditor.AssetDatabase.LoadAssetAtPath<T>(*)", true)]
		public static T LoadAssetAtPath<T>(string assetPath) where T : Object
		{
			return (T)((object)null);
		}
	}
}
