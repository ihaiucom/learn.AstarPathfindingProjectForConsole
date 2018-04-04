using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Gizmos
	{
		public static Color color
		{
            get;
            set;
		}

		public static Matrix4x4 matrix
		{
            get;
            set;
		}

		public static void DrawRay(Ray r)
		{
			Gizmos.DrawLine(r.origin, r.origin + r.direction);
		}

		public static void DrawRay(Vector3 from, Vector3 direction)
		{
			Gizmos.DrawLine(from, from + direction);
		}

		public static void DrawLine(Vector3 from, Vector3 to)
		{
			Gizmos.INTERNAL_CALL_DrawLine(ref from, ref to);
		}

		private static void INTERNAL_CALL_DrawLine(ref Vector3 from, ref Vector3 to)
        {

        }

		public static void DrawWireSphere(Vector3 center, float radius)
		{
			//Gizmos.INTERNAL_CALL_DrawWireSphere(ref center, radius);
		}


		public static void DrawSphere(Vector3 center, float radius)
		{
		}


		public static void DrawWireCube(Vector3 center, Vector3 size)
		{
		}


		public static void DrawCube(Vector3 center, Vector3 size)
		{
		}


		public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation)
		{
		}

		public static void DrawMesh(Mesh mesh, Vector3 position)
		{
		}

		public static void DrawMesh(Mesh mesh)
		{
		}

		public static void DrawMesh(Mesh mesh, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
		{
			Gizmos.DrawMesh(mesh, -1, position, rotation, scale);
		}

		public static void DrawMesh(Mesh mesh, int submeshIndex, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
		{
		}

		public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation)
		{
		}

		public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position)
		{
		}

		public static void DrawMesh(Mesh mesh, int submeshIndex)
		{
		}

		public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation)
		{
		}

		public static void DrawWireMesh(Mesh mesh, Vector3 position)
		{
		}

		public static void DrawWireMesh(Mesh mesh)
		{
		}

		public static void DrawWireMesh(Mesh mesh, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
		{
		}

		public static void DrawWireMesh(Mesh mesh, int submeshIndex, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
		{
		}

		public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation)
		{
		}

		public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position)
		{
		}

		public static void DrawWireMesh(Mesh mesh, int submeshIndex)
		{
		}

		public static void DrawIcon(Vector3 center, string name, [DefaultValue("true")] bool allowScaling)
		{
		}

		public static void DrawIcon(Vector3 center, string name)
		{
		}

		public static void DrawGUITexture(Rect screenRect, Texture texture)
		{
		}

		public static void DrawGUITexture(Rect screenRect, Texture texture, [DefaultValue("null")] Material mat)
		{
		}

		public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, [DefaultValue("null")] Material mat)
		{

        }

		public static void DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder)
		{

        }



		public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect)
		{
		}


    }
}
