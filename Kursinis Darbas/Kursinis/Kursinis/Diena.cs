using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursinis
{
    class Diena
    {
        public int menesis { get; private set; }
        public int diena { get; private set; }

        public string laisvumas { get; private set; }


        public Diena(int menesis, int diena)
        {
            this.menesis = menesis;
            this.diena = diena;
        }


        public Diena(int menesis, int diena, string laisvumas)
        {
            this.menesis = menesis;
            this.diena = diena;
            this.laisvumas = laisvumas;
        }


       
      

    }
}
