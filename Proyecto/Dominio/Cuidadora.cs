using System;
using System.Collections.Generic;

namespace Proyecto.Dominio 
{
    // Metodos get y set
    public class Cuidadora:Personas
    {
        public string Codigo {get;set;}
        public List <Manzanas> Manzanas {get;set;}
        
    }
}