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

            string[] linesPaquete = System.IO.File.ReadAllLines(@"C:\Users\Borking\Desktop\trabajos universidad\Programacion\Parcial\Paquetes.txt");
            Paquetes paquete1 = new Paquetes();
            List<Paquetes> paquetePrueba = new List<Paquetes>(); 
            foreach (string liness in linesPaquete)
            {
                String[] data = liness.Split(";");
                paquetePrueba.Add( new Paquetes(data[0],data[1],data[2])); 
            }

            //CAMION

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Borking\Desktop\trabajos universidad\Programacion\Parcial\Camiones.txt");
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
                if( acumPeso + Convert.ToDouble(paquetePrueba[i].getpesoPaquete()) < Convert.ToDouble(camionPrueba[j].getpesoMaximo())
                    || acumVol + Convert.ToDouble(paquetePrueba[i].getvolpaquete()) < Convert.ToDouble(camionPrueba[j].getvolMaximo()))
                {
                    Console.WriteLine(i + "i");
                    Console.WriteLine(j + "j");

                    // Console.WriteLine("camion " + camionPrueba[j].getidCamion());
                    acumPeso = acumPeso + Convert.ToDouble(paquetePrueba[i].getpesoPaquete());
                    acumVol = acumVol + Convert.ToDouble(paquetePrueba[j].getvolpaquete());
                    // Console.WriteLine("paquete con ID" + paquetePrueba[j].getidPaquete() +" peso " + acumPeso);
                    // Console.WriteLine("Volumen " + acumVol + "\n");
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