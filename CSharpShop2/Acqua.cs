using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2
{
    public class Acqua : Prodotto
    {
        protected int litri;
        protected int massimoContenutoLitri; 
        public Acqua(int prezzo, int iva, int litri, string nome = "prodotto") : base(prezzo, iva, nome)
        {
            this.litri = litri;
        }

        // GETTERS
        public int GetLitri()
        {
            return this.litri;
        }
        //SETTERS
        public int SetLitri(int litri)
        {
            this
        }

    }
}
