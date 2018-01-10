using System;
using System.Drawing;

namespace Snake_0._2
{
    public class Food
    {
        public Rectangle piece;

        private int x, y, height = 10, width = 10;

        public Food(Random rand)
        {
            Generate(rand);
            piece = new Rectangle(x,y,width,height);
        }

        public void Draw(Graphics graphics)
        {
            piece.X = x;
            piece.Y = y;
            graphics.FillRectangle(Brushes.Brown, piece);
        }
        public void Generate(Random rand)
        {
            x = rand.Next(0, 30) * 10;
            y = rand.Next(0, 20) * 10;

        }
    }
}
