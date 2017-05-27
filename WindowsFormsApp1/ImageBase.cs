using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WindowsFormsApp1
{
    class ImageBase : IDisposable
    {
        bool disposed = false;

        private int X;
        private int Y;

        public int Left
        {
            get { return X; }
            set { X = value; }
        }

        public int Top
        {
            get { return Y; }
            set { Y = value; }
        }
    }
}
