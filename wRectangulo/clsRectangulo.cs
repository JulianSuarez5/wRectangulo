using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wRectangulo
{
    internal class clsRectangulo
    {
        private int x; 
        private int y;

        private static int contar = 0;

        public clsRectangulo() 
        {
            x = 0;
            y = 0;
        }

        public clsRectangulo (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public clsRectangulo(double x, double y)
        {
            this.x = (int)x; 
            this.y = (int)y;
        }

        public int obtenX()
        { 
            return x; 
        }

        public int obtenY()
        {
            return y;
        }

        public void cambiarX(int x)
        {
            this.x = x;
        }

        public void cambiarY(int y)
        {
            this.y = y;
        }

        public static int obtenCuenta() 
        { 
            contar += 1;
            return contar; 
        }


    }
}
