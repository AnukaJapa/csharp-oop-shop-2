using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2
{
    public class Acqua : Prodotto
    {
        protected double litri;
        protected int ph; 
        public Acqua(int prezzo, int iva, double litri, int ph, string nome = "prodotto") : base(prezzo, iva, nome)
        {
            
           SetLitri(litri);
            this.ph= ph;

        }

        // GETTERS
        public double GetLitri()
        {
            return this.litri;
        }

        public int GetPhAcqua()
        {
            return this.ph;
        }
        //SETTERS
        public void SetLitri(double litri)
        {

            if (litri > 1.5 || litri <= 0)
            {
                Console.WriteLine("Il prodotto Acqua non può avere come contenuto meno di 0 litri di acqua o più di 1.5 litri");

       
            }
            else
            {
                this.litri = litri;
            }

        }

        public void Bevi(double litriDaBere)
        {
            if(this.litri -litriDaBere > 0)
            {
                this.litri = litri - litriDaBere;
            } else
            {
                this.litri = 0;
            }
        }

        public void Riempi(double litriDaRiempire)
        {
            if(this.litri + litriDaRiempire > 1.5)
            {
                this.litri = 1.5;
            }else
            {
                this.litri = this.litri + litriDaRiempire; 
            }
        }
 
        public void Svuota()
        {
            this.litri = 0;
        }

        public override string StampapProdotto()
        {
            int prezzoSenzaIva = this.prezzo;
            int prezzoConIva = this.GetPrezzoConIva();


            this.descrizione = $@" 
    nome del Prodotto: {this.nome + this.codice}
    codice: {this.codice}
    prezzo del Prodotto: {prezzoSenzaIva}
    prezzo con Iva: {prezzoConIva}
    iva: {this.iva}
    litri contenuti : {this.litri}
    ph : {this.ph}
    sorgente : {this.sorgente}
-----------------------------------------------------
";
            return descrizione;
        }
    }
}
