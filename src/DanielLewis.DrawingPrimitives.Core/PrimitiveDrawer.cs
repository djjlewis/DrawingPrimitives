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

        public void DrawVerticalLine(int startX, int startY, int length, Color color)
        {
            for (int i = 0; i < length; i++)
            {
                Bitmap.SetPixel(startX, startY + i, color);
            }
        }

        public void DrawHorizontalLine(int startX, int startY, int length, Color color)
        {
            for (int i = 0; i < length; i++)
            {
                Bitmap.SetPixel(startX + i, startY, color);
            }
        }

        public void DrawSquareWithLines(int startX, int startY, int length, Color color)
        {
            // Draw the top line of the square
            DrawHorizontalLine(startX, startY, length, color);

            // Draw the right  line of the square
            DrawVerticalLine(startX, startY, length, color);

            // Draw the bottom line of the square
            DrawHorizontalLine(startX, startY + length, length, color);

            // Draw the Left line of the square
            DrawVerticalLine(startX + length, startY, length, color);
        }

        public void DrawSquare(int startX, int startY, int length, Color color)
        {
            var currentX = startX;
            var currentY = startY;

            for (int i = startX; i < length; i++)
            {
                Bitmap.SetPixel(startX + i, currentY, color);
            }

            for (int i = startX; i < length; i++)
            {
                Bitmap.SetPixel(startX, startY + i, color);
            }
        }
    }
}
