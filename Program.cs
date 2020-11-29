using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {

            //PAQUETE

            string[] linesPaquete = System.IO.File.ReadAllLines(@"/Users/miguelcumaco/Desktop/parcialProgramacion/Paquetes.txt");
            Paquetes paquete1 = new Paquetes();
            List<Paquetes> paquetePrueba = new List<Paquetes>(); 
            foreach (string liness in linesPaquete)
            {
                String[] data = liness.Split(";");
                paquetePrueba.Add( new Paquetes(data[0],data[1],data[2])); 
            }

            //CAMION

            string[] lines = System.IO.File.ReadAllLines(@"/Users/miguelcumaco/Desktop/parcialProgramacion/Camiones.txt");
            Camiones camion1 = new Camiones();
            List<Camiones> camionPrueba = new List<Camiones>(); 
            foreach (string line in lines)
            {
                String[] data = line.Split(";");
                camionPrueba.Add( new Camiones(data[0],data[1],data[2])); 
            }           
            int i = 0;
            int j = 0;
            double acumVol = 0;
            double acumPeso = 0;
            Console.WriteLine("inicio template");
            while ( i <  camionPrueba.Count)
            {
                if( acumPeso + Convert.ToDouble(paquetePrueba[j].getpesoPaquete()) < Convert.ToDouble(camionPrueba[i].getpesoMaximo())
                    || acumVol + Convert.ToDouble(paquetePrueba[j].getvolpaquete()) < Convert.ToDouble(camionPrueba[i].getvolMaximo()))
                {
                Console.WriteLine("camion " + paquetePrueba[i].getidPaquete());
                    acumPeso = acumPeso + Convert.ToDouble(paquetePrueba[j].getpesoPaquete());
                    acumVol = acumVol + Convert.ToDouble(paquetePrueba[j].getvolpaquete());
                    Console.WriteLine("peso " + acumPeso);
                    Console.WriteLine("Volumen " + acumVol + "\n");
                    j++;
                }
                else
                {
                    i++;
                    acumPeso = 0;
                    acumVol = 0;
                }
            }

            double volSobante = 0;
            double pesoSobrante = 0;
            for ( int d = j; d < paquetePrueba.Count; d++)
            {
                volSobante = volSobante + Convert.ToDouble(paquetePrueba[d].getvolpaquete());
                pesoSobrante = pesoSobrante + Convert.ToDouble(paquetePrueba[d].getpesoPaquete());
                Console.WriteLine("volumen sobrante " + volSobante/100);
                Console.WriteLine("Peso sobrante " + pesoSobrante);
            }
         Console.WriteLine((paquetePrueba.Count - j) + "paquetes sobrantes" + "\n");
        Console.WriteLine("fin templates2");
        }
    }
}