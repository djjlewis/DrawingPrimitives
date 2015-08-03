using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DanielLewis.DrawingPrimitives.Core
{
    public class PrimitiveDrawer
    {

        //private readonly Bitmap _drawingArea;

        public Bitmap Bitmap { get; private set; }

        public PrimitiveDrawer(Bitmap drawingArea)
        {
            Bitmap = drawingArea;
        }

        public void DrawVerticalLine(int startX, int startY, int length, Color colour)
        {
            for (int i = 0; i < length; i++)
            {
                Bitmap.SetPixel(startX, startY + i, colour);
            }
        }

        public void DrawHorizontalLine(int startX, int startY, int length, Color colour)
        {
            for (int i = 0; i < length; i++)
            {
                Bitmap.SetPixel(startX + i, startY, colour);
            }
        }

        public void DrawSquareWithLines()
        {
            var colour = Color.Purple;
            DrawHorizontalLine(10, 10, 100, colour);
            DrawHorizontalLine(10, 110, 100, colour);
            DrawVerticalLine(110, 10, 100, colour);
            DrawVerticalLine(10, 10, 100, colour);
        }

        public void DrawSquare(int startX, int startY, int length, Color colour)
        {
            var currentX = startX;
            var currentY = startY;

            for (int i = startX; i < length; i++)
            {
                Bitmap.SetPixel(startX + i, currentY, colour);
            }

            for (int i = startX; i < length; i++)
            {
                Bitmap.SetPixel(startX, startY + i, colour);
            }
        }
    }
}
