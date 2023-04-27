using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class Elettrodomestico : Prodotto
    {
        //ATTRIBUTI
        private string marca;
        private string colore;

        //STATI
        public bool accesa;

        //COSTRUTTORE
        public Elettrodomestico(string nome, string descrizione, double prezzo, double iva, string marca, string colore)  : base(nome, descrizione, prezzo, iva) 
        {
            this.marca = marca;
            this.colore = colore;
        }

        //GETTERS
        public string GetMarca()
        {
            return this.marca;
        }

        public string GetColore()
        {
            return this.colore;
        }

        //METODI
        public void Accenditi()
        {
            accesa = true;
            Console.WriteLine("Click!");
        }

        public void Spegniti()
        {
            accesa = false;
            Console.WriteLine("Piiiiiiiii");
        }

        /*
        public void StatoAccensione(bool accesa)
        {
            if (accesa == false)
            {
                this.accesa = false;
                Console.WriteLine("Piiiiiiiii");
            }
            else
            {
                this.accesa = true;
                Console.WriteLine("Click!");
            }
        }*/

        public new void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Colore: " + colore);
            Console.Write("Stato accensione: " );
        }

    }
}
