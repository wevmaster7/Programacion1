using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
   public  class Resta
    { private  double v1, v2, resultado;
    
        public double Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public double V2
        {
            get { return v2; }
            set { v2 = value; }
        }

        public double V1
        {
            get { return v1; }
            set { v1 = value; }
        }
        public Resta() 
        {
            this.v1 = 0;
            this.v2 = 0;
        }

        public double CalcularResta()
        {

            Resultado = V1 - V2;
            return Resultado;
        }

    }
}
