using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    public class Prodotto
    {
        private string nome;
        private string descrizione;
        private double prezzo;
        private double iva;

        public Prodotto(string nome, string descrizione, double prezzo, double iva)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public string GetDescrizione()
        {
            return this.descrizione;
        }

        public double GetPrezzo()
        {
            return this.prezzo;
        }

        public double prezzoConIva()
        {
            return prezzo + (prezzo / 100 * iva);
        }

        public void CambiaPrezzo(double prezzo)
        {
            this.prezzo = prezzo;
        }
        public virtual void StampaProdotto()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Descrizione: " + this.descrizione);
            Console.WriteLine("Prezzo: " + this.prezzo);
            Console.WriteLine("Prezzo con IVA : " + this.prezzoConIva()); 
        }
    }
}
