using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode]
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class GUIStyle
	{
		[NonSerialized]
		internal IntPtr m_Ptr;

		[NonSerialized]
		private GUIStyleState m_Normal;

		[NonSerialized]
		private GUIStyleState m_Hover;

		[NonSerialized]
		private GUIStyleState m_Active;

		[NonSerialized]
		private GUIStyleState m_Focused;

		[NonSerialized]
		private GUIStyleState m_OnNormal;

		[NonSerialized]
		private GUIStyleState m_OnHover;

		[NonSerialized]
		private GUIStyleState m_OnActive;

		[NonSerialized]
		private GUIStyleState m_OnFocused;

		[NonSerialized]
		private RectOffset m_Border;

		[NonSerialized]
		private RectOffset m_Padding;

		[NonSerialized]
		private RectOffset m_Margin;

		[NonSerialized]
		private RectOffset m_Overflow;

		[NonSerialized]
		private Font m_FontInternal;

		internal static bool showKeyboardFocus = true;

		private static GUIStyle s_None;

		public GUIStyleState normal
		{
            get;
            set;
		}

		public GUIStyleState hover
		{
            get;
            set;
		}

		public GUIStyleState active
		{
            get;
            set;
		}

		public GUIStyleState onNormal
		{
            get;
            set;
		}

		public GUIStyleState onHover
		{
            get;
            set;
		}

		public GUIStyleState onActive
		{
            get;
            set;
		}

		public GUIStyleState focused
		{
            get;
            set;
		}

		public GUIStyleState onFocused
		{
            get;
            set;
		}

		public RectOffset border
		{
            get;
            set;
		}

		public RectOffset margin
		{
            get;
            set;
		}

		public RectOffset padding
		{
            get;
            set;
		}

		public RectOffset overflow
		{
            get;
            set;
		}

		[Obsolete("warning Don't use clipOffset - put things inside BeginGroup instead. This functionality will be removed in a later version.")]
		public Vector2 clipOffset
		{
            get;
            set;
		}

		public Font font
		{
            get;
            set;
		}

		public float lineHeight
		{
            get;
		}

		public static GUIStyle none
		{
			get
			{
				if (GUIStyle.s_None == null)
				{
					GUIStyle.s_None = new GUIStyle();
				}
				return GUIStyle.s_None;
			}
		}

		public bool isHeightDependantOnWidth
		{
			get
			{
				return this.fixedHeight == 0f && this.wordWrap && this.imagePosition != ImagePosition.ImageOnly;
			}
		}

		public  string name
		{
			get;
			set;
		}

		public  ImagePosition imagePosition
		{
			get;
			set;
		}

		public  TextAnchor alignment
		{
			get;
			set;
		}

		public  bool wordWrap
		{
			get;
			set;
		}

		public  TextClipping clipping
		{
			get;
			set;
		}

		public Vector2 contentOffset
		{
            get;
            set;
		}

		internal Vector2 Internal_clipOffset
		{
            get;

            set;
		}

		public  float fixedWidth
		{
			get;
			set;
		}

		public  float fixedHeight
		{
			get;
			set;
		}

		public  bool stretchWidth
		{
			get;
			set;
		}

		public  bool stretchHeight
		{
			get;
			set;
		}

		public  int fontSize
		{
			get;
			set;
		}

		public  FontStyle fontStyle
		{
			get;
			set;
		}

		public  bool richText
		{
			get;
			set;
		}

		public GUIStyle()
		{
			//this.Init();
		}

		public GUIStyle(GUIStyle other)
		{
			//this.InitCopy(other);
		}

		~GUIStyle()
		{
			//this.Cleanup();
		}

		internal static void CleanupRoots()
		{
			GUIStyle.s_None = null;
		}

		internal void InternalOnAfterDeserialize()
		{
			//this.m_FontInternal = this.GetFontInternalDuringLoadingThread();
			//this.m_Normal = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(0));
			//this.m_Hover = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(1));
			//this.m_Active = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(2));
			//this.m_Focused = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(3));
			//this.m_OnNormal = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(4));
			//this.m_OnHover = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(5));
			//this.m_OnActive = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(6));
			//this.m_OnFocused = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, this.GetStyleStatePtr(7));
		}

		private static void Internal_Draw(IntPtr target, Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			//Internal_DrawArguments internal_DrawArguments = default(Internal_DrawArguments);
			//internal_DrawArguments.target = target;
			//internal_DrawArguments.position = position;
			//internal_DrawArguments.isHover = ((!isHover) ? 0 : 1);
			//internal_DrawArguments.isActive = ((!isActive) ? 0 : 1);
			//internal_DrawArguments.on = ((!on) ? 0 : 1);
			//internal_DrawArguments.hasKeyboardFocus = ((!hasKeyboardFocus) ? 0 : 1);
			//GUIStyle.Internal_Draw(content, ref internal_DrawArguments);
		}

		public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			//if (Event.current.type != EventType.Repaint)
			//{
			//	Debug.LogError("Style.Draw may not be called if it is not a repaint event");
			//}
			//else
			//{
			//	GUIStyle.Internal_Draw(this.m_Ptr, position, GUIContent.none, isHover, isActive, on, hasKeyboardFocus);
			//}
		}

		public void Draw(Rect position, string text, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
        {
            //if (Event.current.type != EventType.Repaint)
            //{
            //    Debug.LogError("Style.Draw may not be called if it is not a repaint event");
            //}
            //else
            //{
            //    GUIStyle.Internal_Draw(this.m_Ptr, position, GUIContent.Temp(text), isHover, isActive, on, hasKeyboardFocus);
            //}
        }

		public void Draw(Rect position, Texture image, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			//if (Event.current.type != EventType.Repaint)
			//{
			//	Debug.LogError("Style.Draw may not be called if it is not a repaint event");
			//}
			//else
			//{
			//	GUIStyle.Internal_Draw(this.m_Ptr, position, GUIContent.Temp(image), isHover, isActive, on, hasKeyboardFocus);
			//}
		}

		public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
			//if (Event.current.type != EventType.Repaint)
			//{
			//	Debug.LogError("Style.Draw may not be called if it is not a repaint event");
			//}
			//else
			//{
			//	GUIStyle.Internal_Draw(this.m_Ptr, position, content, isHover, isActive, on, hasKeyboardFocus);
			//}
		}

		public void Draw(Rect position, GUIContent content, int controlID)
		{
			this.Draw(position, content, controlID, false);
		}

		public void Draw(Rect position, GUIContent content, int controlID, bool on)
		{
			//if (Event.current.type != EventType.Repaint)
			//{
			//	Debug.LogError("Style.Draw may not be called if it is not a repaint event.");
			//}
			//else if (content != null)
			//{
			//	GUIStyle.Internal_Draw2(this.m_Ptr, position, content, controlID, on);
			//}
			//else
			//{
			//	Debug.LogError("Style.Draw may not be called with GUIContent that is null.");
			//}
		}

		internal void DrawPrefixLabel(Rect position, GUIContent content, int controlID)
		{
			//if (content != null)
			//{
			//	GUIStyle.Internal_DrawPrefixLabel(this.m_Ptr, position, content, controlID, false);
			//}
			//else
			//{
			//	Debug.LogError("Style.DrawPrefixLabel may not be called with GUIContent that is null.");
			//}
		}

		public void DrawCursor(Rect position, GUIContent content, int controlID, int Character)
		{
			//Event current = Event.current;
			//if (current.type == EventType.Repaint)
			//{
			//	Color cursorColor = new Color(0f, 0f, 0f, 0f);
			//	float cursorFlashSpeed = GUI.skin.settings.cursorFlashSpeed;
			//	float num = (Time.realtimeSinceStartup - GUIStyle.Internal_GetCursorFlashOffset()) % cursorFlashSpeed / cursorFlashSpeed;
			//	if (cursorFlashSpeed == 0f || num < 0.5f)
			//	{
			//		cursorColor = GUI.skin.settings.cursorColor;
			//	}
			//	GUIStyle.Internal_DrawCursor(this.m_Ptr, position, content, Character, cursorColor);
			//}
		}

		internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition)
		{
			//if (Event.current.type != EventType.Repaint)
			//{
			//	Debug.LogError("Style.Draw may not be called if it is not a repaint event");
			//}
			//else
			//{
			//	Event current = Event.current;
			//	Color cursorColor = new Color(0f, 0f, 0f, 0f);
			//	float cursorFlashSpeed = GUI.skin.settings.cursorFlashSpeed;
			//	float num = (Time.realtimeSinceStartup - GUIStyle.Internal_GetCursorFlashOffset()) % cursorFlashSpeed / cursorFlashSpeed;
			//	if (cursorFlashSpeed == 0f || num < 0.5f)
			//	{
			//		cursorColor = GUI.skin.settings.cursorColor;
			//	}
			//	Internal_DrawWithTextSelectionArguments internal_DrawWithTextSelectionArguments = default(Internal_DrawWithTextSelectionArguments);
			//	internal_DrawWithTextSelectionArguments.target = this.m_Ptr;
			//	internal_DrawWithTextSelectionArguments.position = position;
			//	internal_DrawWithTextSelectionArguments.firstPos = firstSelectedCharacter;
			//	internal_DrawWithTextSelectionArguments.lastPos = lastSelectedCharacter;
			//	internal_DrawWithTextSelectionArguments.cursorColor = cursorColor;
			//	internal_DrawWithTextSelectionArguments.selectionColor = GUI.skin.settings.selectionColor;
			//	internal_DrawWithTextSelectionArguments.isHover = ((!position.Contains(current.mousePosition)) ? 0 : 1);
			//	internal_DrawWithTextSelectionArguments.isActive = ((controlID != GUIUtility.hotControl) ? 0 : 1);
			//	internal_DrawWithTextSelectionArguments.on = 0;
			//	internal_DrawWithTextSelectionArguments.hasKeyboardFocus = ((controlID != GUIUtility.keyboardControl || !GUIStyle.showKeyboardFocus) ? 0 : 1);
			//	internal_DrawWithTextSelectionArguments.drawSelectionAsComposition = ((!drawSelectionAsComposition) ? 0 : 1);
			//	GUIStyle.Internal_DrawWithTextSelection(content, ref internal_DrawWithTextSelectionArguments);
			//}
		}

		public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter)
		{
			this.DrawWithTextSelection(position, content, controlID, firstSelectedCharacter, lastSelectedCharacter, false);
		}

		public static implicit operator GUIStyle(string str)
		{
            return null;
			//return GUISkin.current.GetStyle(str); ;
		}

		public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
        {
            return Vector2.one;
        }


		public Vector2 CalcSize(GUIContent content)
        {
            return Vector2.one;
        }

		internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints)
		{
			return Vector2.one;
		}

		public Vector2 CalcScreenSize(Vector2 contentSize)
        {
            return Vector2.one;
        }

        public float CalcHeight(GUIContent content, float width)
		{
			return 0;
		}

		public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth)
		{
            minWidth = 0;
            maxWidth = 0;

        }

		public override string ToString()
		{
			return UnityString.Format("GUIStyle '{0}'", new object[]
			{
				this.name
			});
		}
        

    }
}
