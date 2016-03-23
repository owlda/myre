using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceStudy
{
    sealed class MiniVan : Car
    {
        private int miniVanSize;
        public int sizeCar
        {
            get { return miniVanSize; }
            set { miniVanSize = value; }
        }
    }
}
