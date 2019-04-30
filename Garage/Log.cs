using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Log
    {
        //campi privati
        private int garageSelezionato;

        public Log(int garage)
        {
            garageSelezionato = garage;
        }

        #region Methods for CVS logging
        /// <summary>
        /// Ritorna il numero di auto in base al garage selezionato oppure -1 se la ricerca non va a buon fine
        /// </summary>
        /// <param name="splittedLog">lista da cui ottenere il numero di auto</param>
        /// <returns>il numero di auto in base al garage selezionato oppure -1 in caso la ricerca non desse risultati</returns>
        public int NumeroDiAuto(List<string> splittedLog)
        {
            int cars = -1;
            if(Int32.TryParse(splittedLog[3], out int app))
            {
                if (garageSelezionato == 0)
                {
                    if (Convert.ToInt32(splittedLog[14]) == 0)
                        cars = app;
                }
                else if (garageSelezionato == 1)
                {
                    if (Convert.ToInt32(splittedLog[14]) == 1)
                        cars = app;
                }
            }
            return cars;
        }

        /// <summary>
        /// Ritorna il numero di auto elettriche in base al garage selezionato oppure -1 se la ricerca non va a buon fine
        /// </summary>
        /// <param name="splittedLog">lista da cui ottenere il numero di auto elettriche</param>
        /// <returns>il numero di auto elettriche in base al garage selezionato oppure -1 in caso la ricerca non desse risultati</returns>
        public int NumeroDiAutoElettriche(List<string> splittedLog)
        {
            int cars = -1;
            if (Int32.TryParse(splittedLog[4], out int app))
            {
                if (garageSelezionato == 0)
                {
                    if (Convert.ToInt32(splittedLog[14]) == 0)
                        cars = app;
                }
                else if (garageSelezionato == 1)
                {
                    if (Convert.ToInt32(splittedLog[14]) == 1)
                        cars = app;
                }
            }
            return cars;
        }

        /// <summary>
        /// Ritorna il numero di moto in base al garage selezionato oppure -1 se la ricerca non va a buon fine
        /// </summary>
        /// <param name="splittedLog">lista da cui ottenere il numero di moto</param>
        /// <returns>il numero di moto in base al garage selezionato oppure -1 in caso la ricerca non desse risultati</returns>
        public int NumeroDiMoto(List<string> splittedLog)
        {
            int moto = -1;
            if (Int32.TryParse(splittedLog[5], out int app))
            {
                if (garageSelezionato == 0)
                {
                    if (Convert.ToInt32(splittedLog[14]) == 0)
                        moto = app;
                }
                else if (garageSelezionato == 1)
                {
                    if (Convert.ToInt32(splittedLog[14]) == 1)
                        moto = app;
                }
            }
            return moto;
        }

        /// <summary>
        /// Ritorna il numero di furgoni in base al garage selezionato oppure -1 se la ricerca non va a buon fine
        /// </summary>
        /// <param name="splittedLog">lista da cui ottenere il numero di furgoni</param>
        /// <returns>il numero di furgoni in base al garage selezionato oppure -1 in caso la ricerca non desse risultati</returns>
        public int NumeroDiFurgoni(List<string> splittedLog)
        {
            int furgone = -1;
            if (Int32.TryParse(splittedLog[6], out int app))
            {
                if (garageSelezionato == 0)
                {
                    if (Convert.ToInt32(splittedLog[14]) == 0)
                        furgone = app;
                }
                else if (garageSelezionato == 1)
                {
                    if (Convert.ToInt32(splittedLog[14]) == 1)
                        furgone = app;
                }
            }
            return furgone;
        }

        /// <summary>
        /// Ritorna il valore della tariffa delle auto in base al garage selezionato oppure null se la ricerca non va a buon fine
        /// </summary>
        /// <param name="splittedLog">lista da cui ottenere il valore della tariffa delle auto</param>
        /// <returns>il valore della tariffa delle auto in base al garage selezionato oppure null in caso la ricerca non desse risultati</returns>
        public object ValoreTariffaAuto(List<string> splittedLog)
        {
            object tariffa = null;
            if(Int32.TryParse(splittedLog[7], out int app))
            {
                if(garageSelezionato == 0)
                {
                    if (Convert.ToInt32(splittedLog[14]) == 0)
                        tariffa = app;
                }
                else
                {
                    if (Convert.ToInt32(splittedLog[14]) == 1)
                        tariffa = app;
                }
            }
            return tariffa;
        }

        /// <summary>
        /// Ritorna il valore della tariffa delle moto in base al garage selezionato oppure null se la ricerca non va a buon fine
        /// </summary>
        /// <param name="splittedLog">lista da cui ottenere il valore della tariffa delle moto</param>
        /// <returns>il valore della tariffa delle moto in base al garage selezionato oppure null in caso la ricerca non desse risultati</returns>
        public object ValoreTariffaMoto(List<string> splittedLog)
        {
            object tariffa = null;
            if (Int32.TryParse(splittedLog[8], out int app))
            {
                if (garageSelezionato == 0)
                {
                    if (Convert.ToInt32(splittedLog[14]) == 0)
                        tariffa = app;
                }
                else
                {
                    if (Convert.ToInt32(splittedLog[14]) == 1)
                        tariffa = app;
                }
            }
            return tariffa;
        }

        /// <summary>
        /// Ritorna il valore della tariffa del furgone in base al garage selezionato oppure null se la ricerca non va a buon fine
        /// </summary>
        /// <param name="splittedLog">lista da cui ottenere il valore della tariffa del furgone</param>
        /// <returns>il valore della tariffa del furgone in base al garage selezionato oppure null in caso la ricerca non desse risultati</returns>
        public object ValoreTariffaFurgone(List<string> splittedLog)
        {
            object tariffa = null;
            if (Int32.TryParse(splittedLog[9], out int app))
            {
                if (garageSelezionato == 0)
                {
                    if (Convert.ToInt32(splittedLog[14]) == 0)
                        tariffa = app;
                }
                else
                {
                    if (Convert.ToInt32(splittedLog[14]) == 1)
                        tariffa = app;
                }
            }
            return tariffa;
        }

        /// <summary>
        /// Ritorna il nome del garage in base al garage selezionato oppure null se la ricerca non va a buon fine
        /// </summary>
        /// <param name="splittedLog">lista da cui ottenere il nome del garage</param>
        /// <returns>il nome del garage in base al garage selezionato oppure null in caso la ricerca non desse risultati</returns>
        public object Nome(List<string> splittedLog)
        {
            object nome = null;
            if (garageSelezionato == 0)
            {
                if (splittedLog[10] != null && splittedLog[10] != " ")
                {
                    if (Int32.TryParse(splittedLog[14], out int app))
                    {
                        if (app == 0)
                            nome = splittedLog[10];
                    }
                }
            }
            else
            {
                if (splittedLog[10] != null && splittedLog[10] != " ")
                {
                    if (Int32.TryParse(splittedLog[14], out int app))
                    {
                        if (app == 1)
                            nome = splittedLog[10];
                    }
                }
            }
            return nome;
        }

        /// <summary>
        /// Ritorna il valore della durata media del parcheggio delle auto in base al garage selezionato oppure null se la ricerca non va a buon fine
        /// </summary>
        /// <param name="splittedLog">lista da cui ottenere il valore della durata media del parcheggio delle auto</param>
        /// <returns>il valore della durata media del parcheggio delle auto in base al garage selezionato oppure null in caso la ricerca non desse risultati</returns>
        public object DurataParcheggioMedioAuto(List<string> splittedLog)
        {
            object durata = null;
            if (garageSelezionato == 0)
            {
                if (Double.TryParse(splittedLog[11], out double app))
                {
                    if (Convert.ToInt32(splittedLog[14]) == 0)
                    {
                        durata = app;
                    }
                }
            }
            else
            {
                if (Double.TryParse(splittedLog[11], out double app))
                {
                    if (Convert.ToInt32(splittedLog[14]) == 1)
                    {
                        durata = app;
                    }
                }
            }
            return durata;
        }

        /// <summary>
        /// Ritorna il valore della durata media del parcheggio delle moto in base al garage selezionato oppure null se la ricerca non va a buon fine
        /// </summary>
        /// <param name="splittedLog">lista da cui ottenere il valore della durata media del parcheggio delle moto</param>
        /// <returns>il valore della durata media del parcheggio delle moto in base al garage selezionato oppure null in caso la ricerca non desse risultati</returns>
        public object DurataParcheggioMedioMoto(List<string> splittedLog)
        {
            object durata = null;
            if (garageSelezionato == 0)
            {
                if (Double.TryParse(splittedLog[12], out double app))
                {
                    if (Convert.ToInt32(splittedLog[14]) == 0)
                    {
                        durata = app;
                    }
                }
            }
            else
            {
                if (Double.TryParse(splittedLog[12], out double app))
                {
                    if (Convert.ToInt32(splittedLog[14]) == 1)
                    {
                        durata = app;
                    }
                }
            }
            return durata;
        }

        /// <summary>
        /// Ritorna il valore della durata media del parcheggio dei furgoni in base al garage selezionato oppure null se la ricerca non va a buon fine
        /// </summary>
        /// <param name="splittedLog">lista da cui ottenere il valore della durata media del parcheggio dei furgoni</param>
        /// <returns>il valore della durata media del parcheggio dei furgoni in base al garage selezionato oppure null in caso la ricerca non desse risultati</returns>
        public object DurataParcheggioMedioFurgone(List<string> splittedLog)
        {
            object durata = null;
            if (garageSelezionato == 0)
            {
                if (Double.TryParse(splittedLog[13], out double app))
                {
                    if (Convert.ToInt32(splittedLog[14]) == 0)
                    {
                        durata = app;
                    }
                }
            }
            else
            {
                if (Double.TryParse(splittedLog[13], out double app))
                {
                    if (Convert.ToInt32(splittedLog[14]) == 1)
                    {
                        durata = app;
                    }
                }
            }
            return durata;
        }
        #endregion
    }
}
