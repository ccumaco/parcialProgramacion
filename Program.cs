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
            foreach (var item in paquetePrueba)
            {
                Console.WriteLine("ID: " + item.getidPaquete().ToString() + " PESO: " + item.getpesoPaquete().ToString() + " VOLUMEN: " + item.getvolpaquete().ToString());
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
            foreach (var item in camionPrueba)
            {
            Console.WriteLine("ID: " + item.getidCamion().ToString() + " PESO: " + item.getpesoMaximo().ToString() + " VOLUMEN: " + item.getvolMaximo().ToString());
            }
            
            int volSobrante = 0;
            for (int i = 0; i < camionPrueba.Count; i++)
            {   
                for (int j = 0; j <  paquetePrueba.Count; j++)
                {
                    int paquetesSobrantes = 0;
                    if (Convert.ToInt32(paquetePrueba[j].getvolpaquete()) > Convert.ToInt32(camionPrueba[i].getvolMaximo()) 
                    || Convert.ToDouble(paquetePrueba[j].getpesoPaquete()) > Convert.ToDouble(camionPrueba[i].getpesoMaximo()))
                    {
                        paquetesSobrantes = paquetesSobrantes + 1;
                        volSobrante = volSobrante + Convert.ToInt32(paquetePrueba[j].getvolpaquete());
                        Console.WriteLine(volSobrante + "volumen Sobrante");
                        Console.WriteLine(paquetesSobrantes + "paquetes Sobrante");
                    }
                }
            }
        }
        public static void crearPaquete(){
            
        }
                
    }
}