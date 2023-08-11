using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    LineRenderer line;

    List<Vector2> points;
    Vector2 lastPoint;

    private void Awake()
    {
        line = GetComponent<LineRenderer>();
    }

    public void DrawLine(Vector2 mousePos)
    {
        if(points == null)
        {
            points = new List<Vector2>();
            DrawPoint(mousePos);
            return;
        }

        if(Vector2.Distance(lastPoint, mousePos) >= 0.05f)
        {
            DrawPoint(mousePos);
        }
    }

    void DrawPoint(Vector2 point)
    {
        points.Add(point);
        line.positionCount = points.Count;
        line.SetPosition(points.Count - 1, point);
        lastPoint = point;
    }
}
