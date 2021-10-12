using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Practica
{
    class alimentos:Program
    {
        public void Alimentos()
        {
            Program Tienda = new Program();
            alimentos listaAlimentos = new alimentos();
            Frutas listaFrutas = new Frutas();
            Verduras listaVerduras = new Verduras();

            Debug.Log("Alimentos");
            Debug.Log("----------------");
            Debug.Log("Frutas");
            Debug.Log("Verduras");
            Debug.Log("");
            Debug.Log("[-presionar 1 para ir a Frutas-]");
            Debug.Log("[-presionar 2 para ir a Verduras-]");
            
            string str = "1";
            switch (str)
            {
                case "1":
                    listaFrutas.menuFrutas();
                    break;
                case "2":
                    listaVerduras.menuVerduras();
                    break;
                case "0":
                    Tienda.Tienda();
                    break;
            }
        }
    }
}
