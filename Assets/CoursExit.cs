using UnityEngine;
using System.Collections;

public class CoursExit : MonoBehaviour
{
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    [SerializeField] private Texture2D cursorArrow;
    [SerializeField] private Texture2D cursorPickExit;
    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorPickExit, hotSpot, CursorMode.ForceSoftware);
    }

    void OnMouseDown()
    {
        Cursor.SetCursor(cursorPickExit, hotSpot, CursorMode.ForceSoftware);
    }

    void OnMouseUp()
    {
        Cursor.SetCursor(cursorArrow, hotSpot, CursorMode.ForceSoftware);
    }
    void OnMouseExit()
    {
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }
}

