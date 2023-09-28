// See https://aka.ms/new-console-template for more information
using System;
using Proyecto.Dominio;
using Proyecto.Persistencia;

namespace Proyecto.Consola
{
    //Archivo principal para el metodo Main
        public class Program
    {
        private static IRepositorio _repo =new Repositorio(new AppContextS());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddEstablecimientos();
        }
        public static void AddEstablecimientos()
        {
            var Establecimientos = new Establecimientos
            {
                Codigo ="98765", 
                Nombre = "Bar", 
                Responsable = "Catalina",
                Direccion = "Zona Rosa",
                
            };
            _repo.AddEstablecimientos(Establecimientos);
        }
    }
}