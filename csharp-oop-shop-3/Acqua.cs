using Microsoft.VisualBasic;
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
        private double litri = 1.5; //capienza massima
        private int ph;
        private string sorgente;

        //COSTRUTTORE
        public Acqua(string nome, string descrizione, double prezzo, double iva, double litri, int ph, string sorgente) : base(nome, descrizione, prezzo, iva)
        {
            if (ph < 0 || ph > 10)
            {
                throw new Exception("pH non valido");
            }
            
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

        //SETTERS
        // non posso creare un’acqua se la bottiglia ha un ph negativo, oppure superiore a 10
        /*public void SetPh(int ph)
        {
            if (ph < 0 || ph > 10)
            {
                throw new ArgumentOutOfRangeException("pH non valido");
            } else
            { 
                this.ph = ph;
            }
        }*/

        //non posso avere una capienza(litri) sopra la capienza massima o negativa
        public void SetLitri(double litri)
        {
            if (litri < 0 || litri > 1.5)
            {
                throw new ArgumentOutOfRangeException("Capienza non valida");
            }
            else
            {
                this.litri = litri;
            }

        }

        //METODI
        public void Bevi(double litriDaBere)
        {
            //se l’acqua finisce, restituisce un eccezione
            if (litriDaBere < 0)
            {
                throw new ArgumentOutOfRangeException("Non puoi bere in negativo");
            }
            else if (litriDaBere > this.litri)
            {
                throw new ArgumentOutOfRangeException("Non basta");
            }
            else
            {
                Console.WriteLine("Hai bevuto " + litriDaBere + " litri");
            }

        }

        public void Riempi(double litriDaMettere)
        {
            //riempie la bottiglia di acqua e restituisce un eccezione se supero la sua capienza massima
            if (litriDaMettere < 0)
            {
                throw new ArgumentOutOfRangeException("Non puoi riempire in negativo");
            }
            else if (litriDaMettere > this.litri)
            {
                throw new ArgumentOutOfRangeException("è troppa!!!");
            }
            else if (litriDaMettere < this.litri)
            {
                throw new ArgumentOutOfRangeException("Metti, metti!!!");
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

        //un metodo statico convertiInGalloni(double litri) che presa una quantità di litri restituisca la conversione dei litri in galloni,
        //sapendo che 1 litro è equivalente a 3,785 galloni
        public static double convertiInGalloni(double litri)
        {
            const double galloni = 3.785;

            double convGalloni = (litri * galloni);

            return convGalloni;
        }
    }
}
