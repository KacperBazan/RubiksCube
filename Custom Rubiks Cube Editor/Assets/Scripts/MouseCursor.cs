using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    private Color color;
    ColorManager cm;

    public Texture2D CRed;
    public Texture2D CWhite;
    public Texture2D CGreen;
    public Texture2D COrange;
    public Texture2D CYellow;
    public Texture2D CBlue;

    private Color white = new Color(1f, 1f, 1f, 1f);
    private Color blue = new Color(0f, 0f, 1f, 1f);
    private Color red = new Color(1f, 0f, 0f, 1f);
    private Color yellow = new Color(1f, 1f, 0f, 1f);
    private Color green = new Color(0f, 1f, 0f, 1f);
    private Color orange = new Color(1f, 0.5f, 0f, 1f); 

    void Start()
    {
        ActivateCursor();
        cm = FindObjectOfType<ColorManager>();
    }

    void Update()
    {
        UpdateCursorColor();
    }

    public void ActivateCursor()
    {
        Cursor.SetCursor(CWhite, Vector2.zero, CursorMode.Auto);
    }

    public void UpdateCursorColor()
    {
        color = cm.color;

        if (color == white)
        {
            Cursor.SetCursor(CWhite, Vector2.zero, CursorMode.Auto);
        }
        if (color == red)
        {
            Cursor.SetCursor(CRed, Vector2.zero, CursorMode.Auto);
        }
        if (color == blue)
        {
            Cursor.SetCursor(CBlue, Vector2.zero, CursorMode.Auto);
        }
        if (color == orange)
        {
            Cursor.SetCursor(COrange, Vector2.zero, CursorMode.Auto);
        }
        if (color == yellow)
        {
            Cursor.SetCursor(CYellow, Vector2.zero, CursorMode.Auto);
        }
        if (color == green)
        {
            Cursor.SetCursor(CGreen, Vector2.zero, CursorMode.Auto);
        }
    }
}
