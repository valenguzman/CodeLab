using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_COLOR
{
    public class Color
    {
        private int[] argb = new int[4];
        private int profunditatDeColor;
        bool teTransparencia;

        public Color()
        {
        private int[] argb = new int[4];
        profunditatDeColor = 255;
        bool teTransparencia;
        }

        public int ProfunditatColor
        {
            get
            {
                return profunditatDeColor;
            }

            set
            {
                profunditatDeColor = value;
            }
        }

        public bool TeTransparencia
        {
            get
            {
                return teTransparencia;
            }

            set
            {
                teTransparencia = value;
            }
        }
    }


}
