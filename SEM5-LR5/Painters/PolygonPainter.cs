﻿using System.Collections.Generic;
using System.Drawing;

namespace SEM5_LR5.Painters
{
    public class PolygonPainter : LinePainter
    {
        public void DrawPolygon()
        {
            DrawPolygonWithPoints(Points);
        }

        public void DrawPolygonWithPoints(List<Point> points)
        {
            if (points.Count <= 1)
                return;

            foreach(var point in points)
                DrawPoint(point);

            var lastPointIndex = points.Count - 1;

            for (int i = 0; i < lastPointIndex; i++)
            {
                DrawLine(points[i], points[i + 1]);
            }

            DrawLine(points[0], points[lastPointIndex]);
        }
    }
}
