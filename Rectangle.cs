using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_SQA
{
    public class Rectangle
    {
        private int width, length;
        public Rectangle()
        {
            this.width = 1;
            this.length = 1;
        }
        public Rectangle(int w,int h)
        {
            this.width = w;
            this.length = h;
        }
        public int GetLength()
        {
            return this.length;     
        }
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }
        public int GetWidth()
        {
            return this.width;
        }
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }
        public int GetPerimiter()
        {
            return (2*(length + width));
        }
        public int GetArea()
        {
            return (width * length);
        }
    }
}
