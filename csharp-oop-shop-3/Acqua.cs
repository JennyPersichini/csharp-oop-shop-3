using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class Acqua : Prodotto
    {
        //ATTRIBUTI
        private double litri = 1.5;
        private int ph;
        private string sorgente;

        //COSTRUTTORE
        public Acqua(string nome, string descrizione, double prezzo, double iva, double litri, int ph, string sorgente) : base(nome, descrizione, prezzo, iva)
        {
            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;
        }
        
        //GETTERS
        public double GetLitri()
        {
            return this.litri;
        }

        public double GetPh()
        {
            return this.ph;
        }

        public string GetSorgente()
        {
            return this.sorgente;
        }

        //METODI
        public void Bevi(double litriDaBere)
        {
            if (this.litri - litriDaBere > 0)
            {
                this.litri = this.litri - litriDaBere;
                Console.WriteLine("Hai bevuto " + litriDaBere + " litri");
            }
            else
            {
                Console.WriteLine("Oh-oh! è finita!");
                this.litri = 0;
            }
        }

        public void Riempi(double litriDaMettere)
        {
            if (litriDaMettere > this.litri)
            {
                Console.WriteLine("è troppa!!!");
            }
            else if (litriDaMettere < this.litri)
            {
                Console.WriteLine("Metti, metti!!!");
            }
            else
            {
                Console.WriteLine("Bottiglia piena!!!!");
            }
        }

        public void Svuota()
        {
            this.litri = 0;
            Console.WriteLine("Hai svuotato la bottiglia!");
        }

        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("Litri: " + string.Format("{0:F1}", (this.litri)));
            Console.WriteLine("Sorgente: " + sorgente);
            Console.WriteLine("pH: " + ph);
        }
    }
}
