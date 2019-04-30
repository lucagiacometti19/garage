using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Garage
    {
        public Veicolo[] ArrayDiVeicoli { get; set; }

        public int TariffaAuto { get; set; }
        public int TariffaMoto { get; set; }
        public int TariffaFurgone { get; set; }
        public string Nome { get; set; }
        public int NumeroAuto { get; set; }
        public int NumeroMoto { get; set; }
        public int NumeroFurgoni { get; set; }
        public int NumeroAutoElettriche { get; set; }
        public int DurataParcheggioAuto { get; set; }
        public int DurataParcheggioMoto { get; set; }
        public int DurataParcheggioFurgone { get; set; }

        public Garage(int tariffaAuto, int tariffaMoto, int tariffaFurgone, int grandezza, string nome)
        {
            ArrayDiVeicoli = new Veicolo[grandezza];
            TariffaAuto = tariffaAuto;
            TariffaMoto = tariffaMoto;
            TariffaFurgone = tariffaFurgone;
            Nome = nome;
            NumeroAuto = 0;
            NumeroAutoElettriche = 0;
            NumeroFurgoni = 0;
            NumeroMoto = 0;
            DurataParcheggioAuto = 0;
            DurataParcheggioMoto = 0;
            DurataParcheggioFurgone = 0;
        }

        public Garage() { }

        //metodi
        public void EntraVeicoloElettrico(Veicolo unVeicolo)     //il veicolo passato in parametro deve essere elettrico, il metodo non fa controlli
        {
            int pos = Array.IndexOf(ArrayDiVeicoli, null);
            if (pos > 9 || pos == -1) { }
            else
            {
                ArrayDiVeicoli[pos] = unVeicolo;                                   //se unVeicolo ha la proprietà isElettrica significa che deve essere per forza un'auto
                NumeroAutoElettriche++;
            }
        }

        public void EntraVeicoloNonElettrico(Veicolo unVeicolo)      //il veicolo passato in parametro non deve essere elettrico, il metodo non fa controlli
        {
            int pos = Array.IndexOf(ArrayDiVeicoli, null, 10);
            if(pos != -1)
            {
                ArrayDiVeicoli[pos] = unVeicolo;
                if (unVeicolo is Auto)
                    NumeroAuto++;
                else if (unVeicolo is Moto)
                    NumeroMoto++;
                else
                    NumeroFurgoni++;
            }
        }

        public bool IsTargaUnique(string targa)
        {
            bool finito = false; int a = 0; bool risultato = true;
            while (!finito)
            {
                try
                {
                    if (ArrayDiVeicoli[a].Targa == targa)
                    {
                        finito = true;
                        risultato = false;
                    }
                    else
                        a++;
                }
                catch
                {
                    if(a == ArrayDiVeicoli.Length) { finito = true; }
                    a++;
                }
            }
            return risultato;
        }

        public int EsceVeicolo(int posizione, int oraUscita)
        {
            try
            {
                Veicolo veicolo = ArrayDiVeicoli[posizione];
                int durata = oraUscita - veicolo.OraDiIngresso;
                ArrayDiVeicoli[posizione] = null;
                if (veicolo is Auto)
                {
                    if (((Auto)veicolo).IsElettrica) { NumeroAutoElettriche--; DurataParcheggioAuto = durata; return TariffaAuto * durata; }
                    else
                    {
                        NumeroAuto--; DurataParcheggioAuto = durata;
                        return TariffaAuto * durata;
                    }
                }
                else if (veicolo is Moto)
                {
                    NumeroMoto--; DurataParcheggioMoto = durata;
                    return TariffaMoto * durata;
                }
                else
                {
                    NumeroFurgoni--; DurataParcheggioFurgone = durata;
                    return TariffaFurgone * durata;
                }
            }
            catch { return -1; }
        }

        public int CercaVeicolo(string targa)
        {
            bool finito = false; int a = 0;
            while (!finito)
            {
                try
                {
                    if (ArrayDiVeicoli[a].Targa == targa)
                    {
                        finito = true;
                    }
                    else
                        a++;
                }
                catch
                {
                    if (a == ArrayDiVeicoli.Length) { finito = true; a = -3; }
                    a++;
                }
            }
            return a + 1;
        }

        public string CercaVeicolo(int posizione)
        {
            try
            {
                return ArrayDiVeicoli[posizione].Targa;
            }
            catch { return "Parcheggio vuoto o oltre i limiti"; }
        }
    }
}
