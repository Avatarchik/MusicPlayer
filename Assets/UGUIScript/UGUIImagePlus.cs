using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UGUIImagePlus : Image {
    PolygonCollider2D PGcollider;
    new  void  Awake()
    {
        PGcollider = this.GetComponent<PolygonCollider2D>();
    }
    public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
    {
        bool inside = PGcollider.OverlapPoint(screenPoint);
        Debug.Log(inside);
        return inside;
    }
}
