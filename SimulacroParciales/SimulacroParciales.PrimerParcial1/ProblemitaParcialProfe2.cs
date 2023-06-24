using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SimulacroParciales.PrimerParcial1
{
    internal class ProblemitaParcialProfe2
    {
        //* Crear un método público "SopaDeLetras" que reciba dos parámetros y retorne un entero.
        //* 
        //* El primero parámetro es un string y representa una sopa de letras de N líneas donde
        //* cada línea está separada por una coma.
        //* El segundo parámetro es un también un string y representa una palabra a buscar.
        //*
        //* El método deberá retornar el número de línea (contando desde 0) en el que aparece la
        //* palabra.
        //* 
        //* Si la palabra no se encuentra en la sopa de letras se deberá retornar -1.
        //* 
        //* A tener en cuenta: la sopa de letras no es case sensitive.
        
        public static int SopaDeLetras(string sopa, string palabraFind)
        {
            if (sopa == null || palabraFind == null)
            {
               return -1;
            }

            sopa = sopa.Replace(" ", "").ToLower();
            palabraFind = palabraFind.Replace(" ", "").ToLower();
            
            string[] sopaDividida = sopa.Split(',');
           
            return Array.FindIndex(sopaDividida, x => x == palabraFind);
        }
    }
}
