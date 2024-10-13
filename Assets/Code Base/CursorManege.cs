using UnityEngine;

namespace Code_Base
{
    public class CursorManege : MonoBehaviour
    {
        public Texture2D cursorTexture; 
        public Vector2 hotspot = Vector2.zero; 
        void Start()
        {
            Cursor.SetCursor(cursorTexture, hotspot, CursorMode.Auto);
        }
        void OnDisable()
        {
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        }
    }
}
