using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICE_REF_OUT_PARAMS_ENUM_READONLY
{
    class Complexref
    {
        private int real, imag;

        public Complexref(int r, int i)
        {
            this.real = r;
            this.imag = i;
        }

        public int Getreal()
        {
            return real;
        }
        public int Getimag()
        {
            return imag;
        }
        public static  void Reffenecce(ref Complexref obj)
        {
            obj.real += 20;
            obj.imag += 30;
        }
    }
}
