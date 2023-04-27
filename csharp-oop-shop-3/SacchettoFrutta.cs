using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class SacchettoFrutta : Prodotto
    {
        //ATTRIBUTI
        private double quantitaFrutta;

        //COSTRUTTORE
        public SacchettoFrutta(string nome, string descrizione, double prezzo, int iva, double quantitaFrutta) : base(nome, descrizione, prezzo, iva)
        {
            this.quantitaFrutta = quantitaFrutta;
        }

        //GETTERS
        public double GetQuantitaFrutta()
        {
            return this.quantitaFrutta;
        }

        //METODI
        public void MettiNelSacchetto(double quantitaFrutta)
        {
            if (quantitaFrutta > 5)
            {
                Console.WriteLine("Hai superato la quantità massima di pezzi di frutta");
            }
            else
            {
                this.quantitaFrutta = quantitaFrutta;
                Console.WriteLine("Numero frutta al suo interno: " + quantitaFrutta);
            }
        }

        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("Numero frutta al suo interno: " + quantitaFrutta);
        }
    }
}
