using System;
using System.Collections.Generic;
using System.Text;
namespace Parcial
{
    class Camiones
    {
        private string idCamion;
        private string pesoMaximo;
        private string volMaximo;
        public Camiones()
        {
        }
        public Camiones(string idCamion, string pesoMaximo, string volMaximo)
        {
            this.idCamion = idCamion;
            this.pesoMaximo = pesoMaximo;
            this.volMaximo = volMaximo;
        }
        public string getidCamion()
        {
            return this.idCamion;
        }
        public void SetidCamion(string idCamion)
        {
            this.idCamion = idCamion;
        }
        public string getpesoMaximo()
        {
            return this.pesoMaximo;
        }
        public void SetpesoMaximo(string pesoMaximo)
        {
            this.pesoMaximo = pesoMaximo;
        }
        public string getvolMaximo()
        {
            return this.volMaximo;
        }
        public void SetvolMximo(string volMaximo)
        {
            this.volMaximo = volMaximo;
        }
    }
}