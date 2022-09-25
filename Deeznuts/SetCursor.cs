using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCursor : MonoBehaviour
{
  public Texture2D cursor;
  
  void Start()
  {
    Vector2 cursorOrigin = new Vector2(cursor.width / 2,
      cursor.height / 2);
    Cursor.SetCursor(cursor, cursorOrigin, CursorMode.Auto);
    Cursor.visible = true;
  }
}
