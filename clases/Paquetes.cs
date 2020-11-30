using System;
using System.Collections.Generic;
using System.Text;
namespace Parcial
{
    class Paquetes
    {
        private string idPaquete;
        private string volpaquete;
        private string pesoPaquete;
        public int volSobrante = 0;
        public Paquetes()
        {
        }
        public Paquetes(string idPaquete, string volpaquete, string pesoPaquete)
        {
            this.idPaquete = idPaquete;
            this.volpaquete = volpaquete;
            this.pesoPaquete = pesoPaquete;
        }
        public string getidPaquete()
        {
            return this.idPaquete;
        }
        public void SetidPaquete(string idPaquete)
        {
            this.idPaquete = idPaquete;
        }
        public string getpesoPaquete()
        {
            return this.pesoPaquete;
        }
        public void SetpesoPaquete(string pesoPaquete)
        {
            this.pesoPaquete = pesoPaquete;
        }
        public string getvolpaquete()
        {
            return this.volpaquete;
        }
        public void SetvolMximoPaquete(string volpaquete)
        {
            this.volpaquete = volpaquete;
        }
    }
}