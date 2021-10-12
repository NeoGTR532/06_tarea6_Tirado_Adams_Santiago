using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Practica
{
    class Program:MonoBehaviour
    {
        void Start()
        {
            Tienda();
        }
        public int cantidad;
        
        static public void Main(string[] args)
        {
            Program Tienda = new Program();
            Tienda.Tienda();
        }
        
        public void Tienda()
        {
            cantidad = 0;
            Program Tienda = new Program();
            alimentos listaAlimentos = new alimentos();
            Frutas listaFrutas = new Frutas();
            Verduras listaVerduras = new Verduras();

            Debug.Log("Tienda");
            Debug.Log("----------------");
            Debug.Log("Alimentos");
            Debug.Log("Objetos(Cerrado temporalmente)");
            Debug.Log("");
            Debug.Log("[-presionar 1 para ir a Alimentos-]");

            string str = "1";
            switch (str)
            {
                case "1":
                    listaAlimentos.Alimentos();
                    break;
            }
        }
    }
}
